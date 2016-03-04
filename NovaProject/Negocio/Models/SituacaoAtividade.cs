using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Negocio.Models
{
    public class SituacaoAtividade : IEntidade
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public bool Status { get; set; }
        public bool Concluida { get; set; }
        
    }
}
