using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaProjectWF.Models
{
    class Usuario : IEntidade
    {
        public int Id { get; set; }

        [ForeignKey("TipoUsuario")]
        public virtual TipoUsuario TipoUsuario { get; set; }
        [InverseProperty("Usuario")]
        public virtual ICollection<UsuarioProjeto> Projetos { get; set; }
   
        public string Nome { get; set; }
        public string FormacaoAcademica { get; set; }
        public string ExperienciaSistema { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string LinkExterno { get; set; }
        public bool Status { get; set; }
    }
}
