﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;


namespace NovaProjectWF.Models
{
    class Prioridade : IEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}