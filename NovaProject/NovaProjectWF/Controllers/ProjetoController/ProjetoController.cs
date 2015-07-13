using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models;
using NovaProjectWF.View.Utilitarios;
using NovaProjectWF.Dao;
using NovaProjectWF.Models.Enumerados;

namespace NovaProjectWF.Controllers.ProjetoController
{
    class ProjetoController
    {
        ProjetoDAO crud;

        public ProjetoController()
        {
            crud = new ProjetoDAO();
        }

        public Object Salvar(string Id, string titulo, string descricao, string dataInicio, 
            string dataPrevista, byte[] planoProjeto, string dataConclusao, ESituacaoProjeto situacao)
        {

            

            if (Id == string.Empty)
            {
                Id = "0";
            }
            
            if (titulo == string.Empty)
            {
                Mensagem.Erro("Título não pode ser Nulo!");
            }
            else if (descricao == string.Empty)
            {
                Mensagem.Erro("Descrição não pode ser Nula!");
            }
            else if (dataInicio.Replace("_", "").Replace("/", "").Trim() == string.Empty)
            {
                Mensagem.Erro("Data de Início não pode ser Nula!");
            }
            else if (dataPrevista.Replace("_", "").Replace("/", "").Trim() == string.Empty)
            {
                Mensagem.Erro("Data Prevista não pode ser Nula!");
            }
            else if (planoProjeto.Count() == 0)
            {
                Mensagem.Erro("Plano de Projeto não pode ser Nulo!");
            }
            else
            {
                DateTime dtDataInicio = Convert.ToDateTime(dataInicio);
                DateTime dtDataPrevista = Convert.ToDateTime(dataPrevista);

                if (dtDataPrevista.Date < dtDataInicio.Date)
                {
                    Mensagem.Erro("Data Prevista não pode ser anterior a data de Início");

                    return null;
                }

                Projeto projeto = new Projeto();

                if (situacao == ESituacaoProjeto.CONCLUIDO &&
                    (dataConclusao == null || dataConclusao == string.Empty))
                {
                    projeto.DataConclusao = Convert.ToDateTime(DateTime.Now);
                }

                projeto.Titulo = titulo;
                projeto.Descricao = descricao;
                projeto.DataInicio = dtDataInicio;
                projeto.DataPrevisao = dtDataPrevista;
                projeto.PlanoProjeto = planoProjeto;
                projeto.Situacao = situacao;
                Object retorno = crud.save(Convert.ToInt32(Id), projeto);

                return retorno;
            }
            return null;
        }

        public List<Projeto> TodosOsDados()
        {
            return crud.selectAll();
        }

        public Projeto BuscarPorId(string Id)
        {
            return (Projeto)crud.select(Convert.ToInt32(Id));
        }

        internal List<Projeto> ProjetoPorUsuario(int userId)
        {
            UsuarioProjetoDAO upDao = new UsuarioProjetoDAO();

            List<UsuarioProjeto> projetos = upDao.GetProjetosDoUsuario(userId);

            List<Projeto> retorno = new List<Projeto>();

            foreach (var item in projetos)
            {
                int v = Convert.ToInt32(((UsuarioProjeto)item).ProjetoId);
                retorno.Add((Projeto)crud.select(v));                
            }

            return retorno;
        }
    }
}
