using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models;
using NovaProjectWF.View.Utilitarios;
using Negocio.Dao;
using Negocio.Models.Enumerados;

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

            if (descricao == string.Empty)
            {
                descricao = "// " + titulo.ToUpper() + " //";
            }

           
            if (Id == "0" && situacao.Equals(ESituacaoProjeto.CANCELADO))
            {
                Mensagem.Aviso("Projeto não deve ser inserido com status de CANCELADO");
            }
            else  if (crud.selectNomeUnico(titulo, Convert.ToInt32(Id)).Count >= 1)
            {
                Mensagem.Erro("Nome do Projeto já existe");
            }

            else if (titulo == string.Empty)
            {
                Mensagem.Erro("Título não pode ser Nulo!");
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
            else if (!situacao.Equals(ESituacaoProjeto.NAO_INICIADO)  && DateTime.Today < Convert.ToDateTime(dataInicio))
            {
                Mensagem.Aviso("Projeto não pode ser iniciado, data de início maior que data atual");
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
