using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Models
{
    class UsuarioProjeto : IEntidade
    {
        public int Id { get; set; }

        public virtual Projeto Projeto { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual PapelUsuario PapelUsuario { get; set; }
    }
}

