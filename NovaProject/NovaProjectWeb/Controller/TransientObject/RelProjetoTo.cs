using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaProjectWeb.Controller.TransientObject
{
    public class RelProjetoTo
    {
        public string NomeAtividade { get; set; }
        public string NomeUsuario { get; set; }
        public string NomeProjeto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DatConclusao { get; set; }
        public string TempoGasto {get;set;}

    }
}