using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Models
{
    class Atividade : IEntidade
    {
        public int Id { get; set; }

        public virtual TipoAtividade TipoAtividade { get; set; }
        public virtual SituacaoAtividade Situacao { get; set; }
        public virtual Usuario Colaborador { get; set; }
        public virtual FaseProjeto FaseProjeto { get; set; }

        public string Titulo { get; set; }
        public string Prioridade { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataFim { get; set; }
        public int TempoEstimado { get; set; }
        public int TempoGasto { get; set; }
    }
}
