using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Models
{
    class TipoAtividade : IEntidade
    {
        public int Id { get; set; }
        public string nome { get; set; }
    }
}
