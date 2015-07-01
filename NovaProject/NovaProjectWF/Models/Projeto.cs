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
           public string nome { get; set; }
           public string descricao { get; set; }
           public DateTime dataInicio { get; set; }
           public DateTime dataPrevisao {get; set; }
           public Boolean situacao { get; set; }
           public string planoProjeto { get; set; }
      
    }
}
