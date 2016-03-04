using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models.Interfaces;
using Negocio.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Negocio.Models.Enumerados;

/**
 * Class Atividade
 * */
namespace Negocio.Models
{
    public class Atividade : IEntidade
    {
        public int Id { get; set; }

        public int FaseProjetoId { get; set; }
        public int UsuarioId { get; set; }
        public int TipoAtividadeId { get; set; }
        public int SituacaoAtividadeId { get; set; }

        [ForeignKey("FaseProjetoId")]
        public virtual FaseProjeto FaseProjeto { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Colaborador { get; set; }
        [ForeignKey("TipoAtividadeId")]
        public virtual TipoAtividade TipoAtividade{ get; set; }
        [ForeignKey("SituacaoAtividadeId")]
        public virtual SituacaoAtividade SituacaoAtividade { get; set; }
        
        [InverseProperty("Atividade")]
        public virtual ICollection<AnexoAtividade> Anexos { get; set; }

        [Required]
        public EPrioridade Prioridade { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataPrevista { get; set; }
        
        public DateTime? DataFim { get; set; }
        public double TempoEstimado { get; set; }
        public double? TempoGasto { get; set; }
    }
}