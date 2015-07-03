using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

/**
 * Classe FaseProjeto
 * */
namespace NovaProjectWF.Models
{
    class FaseProjeto : IEntidade
    {
        public int Id { get; set; }
        [ForeignKey("Projeto"), Required]
        public virtual Projeto Projeto { get; set; }
        [InverseProperty("FaseProjeto")]
        public virtual ICollection<UsuarioProjeto> Usuarios { get; set; }

        [Required]
        public string Descricao { get; set; }
        [Timestamp, Required]
        public DateTime DataInicio { get; set; }
        [Timestamp]
        public DateTime DataFim { get; set; }
        [Required]
        public bool Status { get; set; } 

    }
}
