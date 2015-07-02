using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Models
{
    class Usuario : IEntidade
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string formacaoAcademica { get; set; }
        public string experienciaSistema { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string linkExterno { get; set; }
    }
}
