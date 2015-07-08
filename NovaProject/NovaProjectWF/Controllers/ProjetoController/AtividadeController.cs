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
    class AtividadeController
    {
        AtividadeDAO crud;

        public AtividadeController()
        {
            crud = new AtividadeDAO();
        }

        public List<Atividade> GetAtividadesDaFase(int FaseProjetoId)
        {
            crud = new AtividadeDAO();

            List<Atividade> lista = crud.GetAtividadesDaFase(FaseProjetoId);

            return lista;
        }

        public Object Salvar(string Id, EPrioridade prioridade, SituacaoAtividade situacaoAtividade, 
            double tempoEstimado, double? tempoGasto, TipoAtividade tipoAtividade, string titulo, 
            Usuario usuario, DateTime? dataFim, DateTime dataInicio, DateTime dataPrevista, string descricao, 
            FaseProjeto faseProjeto)
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
                Mensagem.Erro("Data de Inicio não pode ser Nula!");
            }
            else if (Convert.ToString(dataPrevista) == string.Empty)
            {
                Mensagem.Erro("Data Prevista não pode ser Nula!");
            }
            else if (prioridade == null)
            {
                Mensagem.Erro("Prioridade não pode ser Nula!");
            }
            else if (Convert.ToString(tempoEstimado) == string.Empty)
            {
                Mensagem.Erro("Tempo Estimado não pode ser Nulo!");
            }
            else if (dataPrevista < dataInicio)
            {
                Mensagem.Erro("Data Prevista não pode ser menor que data Início!");
            }
            else
            {
                Atividade atividade = new Atividade();

                if (situacaoAtividade.Concluida && dataFim == null)
                {
                    atividade.DataFim = Convert.ToDateTime(DateTime.Now);
                }

                atividade.Prioridade = prioridade;
                atividade.SituacaoAtividadeId = situacaoAtividade.Id;
                atividade.TempoEstimado = tempoEstimado;
                atividade.TempoGasto = tempoGasto;
                atividade.TipoAtividadeId = tipoAtividade.Id;
                atividade.Titulo = titulo;
                atividade.UsuarioId = usuario.Id;
                atividade.DataInicio = dataInicio;
                atividade.DataPrevista = dataPrevista;
                atividade.Descricao = descricao;
                atividade.FaseProjetoId = faseProjeto.Id;

                Object retorno = crud.save(Convert.ToInt32(Id), atividade);

                return retorno;
            }
            return null;
        }

        public List<Atividade> GetAtividadePorSituacao(SituacaoAtividade atv)
        {
           return crud.selectPorSituacao(atv);
        }

        public Atividade BuscarPorId(string Id)
        {
            return (Atividade)crud.select(Convert.ToInt32(Id));
        }

        public List<Atividade> BuscarPorNomeOuDescricao(string valor)
        {
            return crud.selectPorNomeOuDescrica(valor);
        }
    }
}
