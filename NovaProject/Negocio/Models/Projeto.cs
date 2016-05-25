using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Negocio.Models.Enumerados;

namespace Negocio.Models
{
    public class Projeto : IEntidade
    {
           public int Id { get; set; }

           [InverseProperty("Projeto")]     
           public virtual ICollection<FaseProjeto> FaseProjeto { get; set; }
           [InverseProperty("Projeto")]
           public virtual ICollection<AnexoProjeto> Anexos {get; set;}
           [InverseProperty("Projeto")]
           public virtual ICollection<UsuarioProjeto> Usuarios { get; set; }
           [Required]
           public string Titulo { get; set; } 
           [Required]
           public string Descricao { get; set; }
           public DateTime DataInicio { get; set; }
           public DateTime DataPrevisao {get; set; }
           public DateTime DataConclusao { get; set; }
           [Required]
           public byte[] PlanoProjeto { get; set; }
           public ESituacaoProjeto Situacao { get; set; }
      }
}
