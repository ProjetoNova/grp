using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models.Interfaces;

namespace Negocio.Models
{
    public class TipoAtividade : IEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }

    }
}
