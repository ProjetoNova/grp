using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Models
{
    class TipoUsuario : IEntidade
    {
        public int Id { get; set; }
        public string descricao { get; set; }
    }
}
