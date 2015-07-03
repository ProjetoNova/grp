using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaProjectWF.Models
{
    class UsuarioProjeto : IEntidade
    {
        public int Id { get; set; }

        public int FaseProjetoId { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("FaseProjetoId")]
        public virtual FaseProjeto FaseProjeto { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

        public string Papel { get; set; }
    }
}
