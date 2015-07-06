using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models;
using NovaProjectWF.View.Utilitarios;
using NovaProjectWF.Dao;

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
            DateTime dataPrevista, byte planoProjeto, DateTime dataConclusao, byte anexo)
        {
            
            if (Id == string.Empty)
            {
                Id = "0";
            }
            else if (titulo == string.Empty)
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
            else if (Convert.ToString(planoProjeto) == string.Empty)
            {
                Mensagem.Erro("Plano de Projeto não pode ser Nulo!");
            }
            else if (Convert.ToString(dataConclusao) == string.Empty)
            {
                Mensagem.Erro("Data de Conclusao não pode ser Nula!");
            }
            
            else
            {
                Projeto projeto = new Projeto();

                projeto.Titulo = titulo;
                projeto.Descricao = descricao;
                projeto.DataInicio = dataInicio;
                projeto.DataPrevisao = dataPrevista;
                projeto.PlanoProjeto = planoProjeto;
                projeto.DataConclusao = dataConclusao;
                projeto.Anexos = anexo;
                //Duvidas em relação a 'anexo' e 'planoProjeto' sobre a sintaxe correta acima
                Object retorno = crud.save(Convert.ToInt32(Id), projeto);

                return retorno;
            }

        }
    }
}
