using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Models
{
    class Projeto : IEntidade
    {
           public int Id { get; set; }

           public virtual UsuarioProjeto UsuarioProjeto { get; set; }
           public virtual FaseProjeto FaseProjeto { get; set; }

           public string Nome { get; set; }
           public string Descricao { get; set; }
           public DateTime DataInicio { get; set; }
           public DateTime DataPrevisao {get; set; }
           //public Boolean Situacao { get; set; }
           public string PlanoProjeto { get; set; }
      
    }
}
