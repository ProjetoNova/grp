using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

/**
 * Classe AnexoProjeto
 * */
namespace Negocio.Models
{
    public class AnexoProjeto : IEntidade
    {
        public int Id { get; set; }

        public int ProjetoId { get; set; }

        public int UsuarioId { get; set; }

        public DateTime Data { get; set; }

        public string Observacoes { get; set; }
                
        public byte[] Anexo { get; set; }

        public string NomeArquivo { get; set; }

        [ForeignKey("ProjetoId")]
        public Projeto Projeto { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

    }
}
