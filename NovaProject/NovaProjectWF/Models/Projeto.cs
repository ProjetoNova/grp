using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NovaProjectWF.Models
{
    class Projeto : IEntidade
    {
           public int Id { get; set; }

           [InverseProperty("Projeto")]     
           public virtual ICollection<FaseProjeto> FaseProjeto { get; set; }
           [InverseProperty("Projeto")]
           public virtual ICollection<AnexoProjeto> Anexos {get; set;}

           [Required]
           public string Nome { get; set; }
           [Required]
           public string Descricao { get; set; }
           [Required]
           public DateTime DataInicio { get; set; }
           [Required]
           public DateTime DataPrevisao {get; set; }
           [Required]
           public string PlanoProjeto { get; set; }
      
    }
}
