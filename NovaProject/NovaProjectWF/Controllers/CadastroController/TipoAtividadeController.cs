using Negocio.Dao;
using Negocio.Models;
using NovaProjectWF.View.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Controllers.CadastroController
{
    class TipoAtividadeController
    {
        TipoAtvidadeDAO crud;

         public TipoAtividadeController()
        {
            crud = new TipoAtvidadeDAO();
        }

        public Object Salvar(string Id, string Nome, bool Status)
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
                TipoAtividade tipoAtividade = new TipoAtividade();

                tipoAtividade.Nome = Nome;
                tipoAtividade.Status = Status;

                Object retorno = crud.save(Convert.ToInt32(Id), tipoAtividade);

                return retorno;
            }

            return null;
        }

        public TipoAtividade BuscarPorId(string Id)
        {
            return (TipoAtividade)crud.select(Convert.ToInt32(Id));
        }

        public List<TipoAtividade> BuscarPorNome(string nome)
        {
            return (List<TipoAtividade>)crud.selectNome(nome);
        }

        public List<TipoAtividade> TodosOsDados()
        {
            return crud.selectAll();
        }

        public List<string> TodosOsNomes()
        {
            List<String> nomes = new List<String>();

            foreach (TipoAtividade t in crud.selectAll())
            {
                nomes.Add(t.Nome);
            }

            return nomes;
        }

    }
}
