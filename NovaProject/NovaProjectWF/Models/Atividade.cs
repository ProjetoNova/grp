using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using NovaProjectWF.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

/**
 * Class Atividade
 * */
namespace NovaProjectWF.Models
{
    class Atividade : IEntidade
    {
        public int Id { get; set; }

        [ForeignKey("FaseProjeto"), Required]
        public virtual FaseProjeto FaseProjeto { get; set; }
        [ForeignKey("Colaborador"), Required]
        public virtual Usuario Colaborador { get; set; }
        [ForeignKey("TipoAtividade"), Required]
        public virtual TipoAtividade TipoAtividade{ get; set; }
        
        [InverseProperty("Atividade")]
        public virtual ICollection<AnexoAtividade> Anexos { get; set; }
        /**COLOCAR CLASSE PRIORIDADE**/
        [Required]
        public string Prioridade { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Timestamp, Required]
        public DateTime DataInicio { get; set; }
        [Timestamp, Required]
        public DateTime DataPrevista { get; set; }
        [Timestamp]
        public DateTime DataFim { get; set; }
        public double TempoEstimado { get; set; }
        public double TempoGasto { get; set; }
    }
}
