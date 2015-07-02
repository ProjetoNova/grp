using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using NovaProjectWF.Models.Enumerados;

namespace NovaProjectWF.Models
{
    class Projeto : IEntidade
    {
           public int Id { get; set; }

           public virtual ICollection<FaseProjeto> FasesProjeto { get; set; }
           public virtual ICollection<UsuarioProjeto> UsuariosProjeto { get; set; }
           public ESituacaoProjeto Situacao { get; set; }

           public string Titulo { get; set; }
           public string Descricao { get; set; }
           public DateTime DataInicio { get; set; }
           public DateTime DataPrevisao {get; set; }
           public DateTime DataFim { get; set; } 
           public string PlanoProjeto { get; set; } 
       
    }
}
