using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Models
{
    class FaseProjeto : IEntidade
    {
        public int Id { get; set; }

        public virtual Projeto Projeto { get; set; }

        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Status { get; set; } 

    }
}
