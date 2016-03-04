using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models;
using NovaProjectWF.View.Utilitarios;
using Negocio.Dao;

namespace NovaProjectWF.Controllers.CadastroController
{
    class SituacaoAtividadeController
    {
        SituacaoAtividadeDAO crud;

        public SituacaoAtividadeController()
        {
            crud = new SituacaoAtividadeDAO();
        }

        public Object Salvar(string Id, string Nome, bool Status, bool Concluida)
        {

            if (Id == string.Empty)
            {
                Id = "0";
            }

            if (Nome == string.Empty)
            {
                Mensagem.Erro("Nome não pode ser Nulo!");
            }
            else
            {
                SituacaoAtividade situacao = new SituacaoAtividade();

                situacao.Nome = Nome;
                situacao.Status = Status;
                situacao.Concluida = Concluida;

                Object retorno = crud.save(Convert.ToInt32(Id), situacao);

                return retorno;
            }

            return null;
        }

        public SituacaoAtividade BuscarPorId(string Id)
        {
            return (SituacaoAtividade)crud.select(Convert.ToInt32(Id));
        }

        public List<SituacaoAtividade> BuscarPorNome(string nome)
        {
            return (List<SituacaoAtividade>)crud.selectNome(nome);
        }

        public List<SituacaoAtividade> TodosOsDados()
        {
            return crud.selectAll();
        }

        public List<string> TodosOsNomes()
        {
            List<String> nomes = new List<String>();

            foreach (SituacaoAtividade t in crud.selectAll())
            {
                nomes.Add(t.Nome);
            }

            return nomes;
        }

    }
}
