using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

/**
 * Classe AnexoProjeto
 * */
namespace NovaProjectWF.Models
{
    class AnexoProjeto : IEntidade
    {
        public int Id { get; set; }

        public int ProjetoId { get; set; }
                
        public byte[] Anexo { get; set; }
        [ForeignKey("ProjetoId")]
        public Projeto Projeto { get; set; }

    }
}
