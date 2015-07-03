using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NovaProjectWF.Models
{
    class SituacaoAtividade : IEntidade
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public bool Status { get; set; }
        public bool Concluida { get; set; }
        
    }
}
