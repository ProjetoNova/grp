using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Models.NaoPersistido
{
    class AtividadeProjeto
    {
        public string Id { get; set; }
        public string Situacao { get; set; }
        public string Prioridade { get; set; }
        public string Titulo { get; set; }
        public DateTime dtInicio { get; set; }
        public DateTime dtPrevista { get; set; }
        public DateTime dtFim { get; set; }
    
    }
}
