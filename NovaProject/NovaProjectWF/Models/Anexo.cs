using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Models
{
    class Anexo : IEntidade
    {
        public int Id { get; set; }
        public byte[] Arquivo { get; set; }
        public string Descricao { get; set; }
    }
} 
