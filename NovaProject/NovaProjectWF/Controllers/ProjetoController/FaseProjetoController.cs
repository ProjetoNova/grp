using NovaProjectWF.Dao;
using NovaProjectWF.Models;
using NovaProjectWF.View.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Controllers.ProjetoController
{
    class FaseProjetoController
    {
        FaseProjetoDAO crud;

        public FaseProjetoController()
        {
            crud = new FaseProjetoDAO();
        }

        public Object NovaFase(string Id, int ProjetoId, string Descricao, DateTime DataInicio,
            DateTime DataFim, bool Status)
        {
            Object retorno = null;

            if (Id == string.Empty)
            {
                Id = "0";
            }

            if (Descricao == string.Empty)
            {
                Mensagem.Erro("Descrição não pode ser nula!");
            }
            else if (DataInicio > DataFim)
            {
                Mensagem.Erro("Data Fim não pode ser menor que Data Início!");
            }
            else if (ProjetoId == 0)
            {
                Mensagem.Erro("Não é possível incluir fase sem projeto!");
            }
            else
            {
                FaseProjeto faseProjeto = new FaseProjeto();

                faseProjeto.ProjetoId = ProjetoId;
                faseProjeto.Descricao = Descricao;
                faseProjeto.DataInicio = DataInicio;
                faseProjeto.DataFim = DataFim;
                faseProjeto.Status = Status;

                retorno = crud.save(Convert.ToInt32(Id), faseProjeto);
            }

            return retorno;
        }

        public List<FaseProjeto> GetFasesDoProjeto(int ProjetoId)
        {
            List<FaseProjeto> lista = crud.GetFasesDoProjeto(ProjetoId);

            return lista;
        }

        public FaseProjeto BuscarPorId(string Id)
        {
            return (FaseProjeto)crud.select(Convert.ToInt32(Id));
        }

        public List<FaseProjeto> BuscarPorNome(int projetoId, string nome)
        {
            return crud.selectNome(projetoId, nome);
        }
    }
}
