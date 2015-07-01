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
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataPrevista { get; set; }
        public DateTime dataFim { get; set; }
        public int tempoEstimado { get; set; }
        public int tempoGasto { get; set; }
        public string prioridade { get; set; }
    }
}
