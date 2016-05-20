using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models;
using NovaProjectWF.View.Utilitarios;
using Negocio.Dao;
using Negocio.Models.Enumerados;
using NovaProjectWF.Controllers.CadastroController;
using Negocio.Models.NaoPersistido;

namespace NovaProjectWF.Controllers.ProjetoController
{
    class AtividadeController
    {
        AtividadeDAO crud;

        public AtividadeController()
        {
            crud = new AtividadeDAO();
        }

        public List<AtividadeProjeto> GetAtividadesDaFase(int FaseProjetoId)
        {
            crud = new AtividadeDAO();

            List<Atividade> lista = crud.GetAtividadesDaFase(FaseProjetoId);

            List<AtividadeProjeto> listaRetonrno = new List<AtividadeProjeto>();

            SituacaoAtividadeController control = new SituacaoAtividadeController();

            foreach (Atividade item in lista)
            {
                AtividadeProjeto atp = new AtividadeProjeto();
                atp.Id = item.Id+"";
                atp.Situacao = control.BuscarPorId(item.SituacaoAtividadeId + "").Nome;
                atp.Titulo = item.Titulo;
                atp.Prioridade = Prioridade.GetValue(item.Prioridade);
                atp.dtInicio = item.DataInicio;
                atp.dtPrevista = item.DataPrevista;
                atp.dtFim = Convert.ToDateTime(item.DataFim);
                listaRetonrno.Add(atp);
            }

            return listaRetonrno;
        }

        private double HorasProjeto(Negocio.Models.Projeto proj)
        {
            double tempoTotal = 0;
            double dataInicio = proj.DataInicio.Value.ToOADate();
            double dataFim = proj.DataPrevisao.Value.ToOADate();

            tempoTotal = dataFim - dataInicio;

            if (tempoTotal == 0)
            {
                tempoTotal = 1;
            }

            return tempoTotal*2400;
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
            
            ProjetoController pc = new ProjetoController();
            Negocio.Models.Projeto p = pc.BuscarPorId(faseProjeto.ProjetoId + "");

            if (tempoEstimado > HorasProjeto(p)) 
            {
                Mensagem.Aviso("Tempo Estimado é maior que o total de horas do projeto");
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
            else if (prioridade == null)
            {
                Mensagem.Erro("Prioridade não pode ser Nula!");
            }
            else if (Convert.ToString(tempoEstimado) == string.Empty)
            {
                Mensagem.Erro("Tempo Estimado não pode ser Nulo!");
            }
            else if (dataPrevista.Date < dataInicio.Date)
            {
                Mensagem.Erro("Data Prevista não pode ser menor que data Início!");
            }
            else if (usuario == null)
            {
                Mensagem.Erro("Deve haver um responsável pela atividade");
            }
            else
            {
                Atividade atividade = new Atividade();

                if (situacaoAtividade.Concluida && dataFim == null)
                {
                    atividade.DataFim = Convert.ToDateTime(DateTime.Now);
                }
                else
                {
                    atividade.DataFim = dataFim;
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
