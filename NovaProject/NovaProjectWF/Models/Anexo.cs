using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.Data.Entity;


namespace NovaProjectWF.Models
{
    class Anexo : IEntidade
    {
        public int Id { get; set; }
        public byte anexo { get; set; }
    }
}
