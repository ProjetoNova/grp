using Negocio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class PermissaoTipoUsuario : IEntidade
    {
        public int Id { get; set; }

        public int TipoUsuarioId { get; set; }

        public int PermissaoIndice { get; set; }

    }
}
