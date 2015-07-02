using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using NovaProjectWF.Models.Enumerados;

namespace NovaProjectWF.Models
{
    class FaseProjeto : IEntidade
    {
        public int Id { get; set; }

        public virtual Projeto Projeto { get; set; }
        public ESituacaoProjeto SituacaoFase { get; set; }

        public string NomeFase { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; } 

    }
}
