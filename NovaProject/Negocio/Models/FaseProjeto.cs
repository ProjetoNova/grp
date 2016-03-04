using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

/**
 * Classe FaseProjeto
 * */
namespace Negocio.Models
{
    public class FaseProjeto : IEntidade
    {
        public int Id { get; set; }

        public int ProjetoId { get; set; }

        [ForeignKey("ProjetoId")]
        public virtual Projeto Projeto { get; set; }
        
        [Required]
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Status { get; set; } 
    }
}
