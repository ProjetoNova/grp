using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Models
{
    public class UsuarioProjeto : IEntidade
    {
        public int Id { get; set; }

        public int? ProjetoId { get; set; }
        public int? UsuarioId { get; set; }
        public int? TipoUsuarioId { get; set; }

        [ForeignKey("ProjetoId")]
        public virtual Projeto Projeto { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("TipoUsuarioId")]
        public virtual TipoUsuario Papel { get; set; }

        public DateTime? InicioProjeto { get; set; }
        public DateTime? FimProjeto { get; set; }
        public bool Status { get; set; }
        public string Observacao { get; set; }

    }
}
