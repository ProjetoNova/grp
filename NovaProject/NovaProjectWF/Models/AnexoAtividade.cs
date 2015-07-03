using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

/**
 * Classe AnexoAtividade
 * */
namespace NovaProjectWF.Models
{
    class AnexoAtividade : IEntidade
    {
        public int Id { get; set; }
        [ForeignKey("Anexo")]
        public Anexo Anexo { get; set; }
        [ForeignKey("Atividade")]
        public Atividade Atividade { get; set; }
    }
}
