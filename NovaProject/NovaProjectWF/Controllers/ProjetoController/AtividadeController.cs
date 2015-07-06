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
    class AtividadeController
    {
        AtividadeDAO crud;

        public AtividadeController()
        {
            crud = new AtividadeDAO();
        }

        public Object Salvar(string Id, string titulo, string descricao, bool situacaoAtividade,
            DateTime dataInicio, DateTime dataPrevista, DateTime dataFinal, string colaborador, string prioridade, double tempoGasto,
            double tempoEstimado, byte anexo)
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
                Mensagem.Erro("Data de Inicio não pode ser Nula!");
            }
            else if (Convert.ToString(dataPrevista) == string.Empty)
            {
                Mensagem.Erro("Data Prevista não pode ser Nula!");
            }
            else if (Convert.ToString(dataFinal) == string.Empty)
            {
                Mensagem.Erro("Data de Conclusão não pode ser Nula!");
            }
            else if (prioridade == string.Empty)
            {
                Mensagem.Erro("Prioridade não pode ser Nula!");
            }
            else if (Convert.ToString(tempoGasto) == string.Empty)
            {
                Mensagem.Erro("Tempo Gasto não pode ser Nulo!");
            }
            else if (Convert.ToString(tempoEstimado) == string.Empty)
            {
                Mensagem.Erro("Tempo Estimado não pode ser Nulo!");
            }
            /////
            else
            {
                Atividade atividade = new Atividade();

                atividade.Titulo = titulo;
                atividade.Descricao = descricao;
                atividade.DataInicio = dataInicio;
                atividade.DataPrevista = dataPrevista;
                atividade.Prioridade = prioridade;
                atividade.TempoGasto = tempoGasto;
                atividade.TempoEstimado = tempoEstimado;
                atividade.Anexos = anexo;
                //Duvidas em relação a 'anexo' e 'prioridade' sobre a sintaxe correta acima
                Object retorno = crud.save(Convert.ToInt32(Id), atividade);

                return retorno;
            }
        }
    }
}
