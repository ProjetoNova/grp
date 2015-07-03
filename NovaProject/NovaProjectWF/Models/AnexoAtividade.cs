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

        public int AtividadeId { get; set; }        
        
        public byte[] Anexo { get; set; }

        [ForeignKey("AtividadeId")]
        public Atividade Atividade { get; set; }
    }
}
