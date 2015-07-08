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

        public Object Salvar(string Id, string titulo, string descricao, DateTime dataInicio, 
            DateTime dataPrevista, byte[] planoProjeto, DateTime dataConclusao, ESituacaoProjeto situacao)
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
            else if (Convert.ToString(dataInicio) == string.Empty)
            {
                Mensagem.Erro("Data de Início não pode ser Nula!");
            }
            else if (Convert.ToString(dataPrevista) == string.Empty)
            {
                Mensagem.Erro("Data Prevista não pode ser Nula!");
            }
            else if (planoProjeto.Count() == 0)
            {
                Mensagem.Erro("Plano de Projeto não pode ser Nulo!");
            }
            else if (Convert.ToString(dataConclusao) == string.Empty)
            {
                Mensagem.Erro("Data de Conclusao não pode ser Nula!");
            }
            else if (dataPrevista < dataInicio)
            {
                Mensagem.Erro("Data Prevista não pode ser anterior a data de Início");
            }
            else
            {
                Projeto projeto = new Projeto();

                if (situacao.Equals(ESituacaoProjeto.CONCLUIDO) && dataConclusao == null)
                {
                    projeto.DataConclusao = Convert.ToDateTime(DateTime.Now);
                }

                projeto.Titulo = titulo;
                projeto.Descricao = descricao;
                projeto.DataInicio = dataInicio;
                projeto.DataPrevisao = dataPrevista;
                projeto.PlanoProjeto = planoProjeto;
                projeto.DataConclusao = dataConclusao;
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
