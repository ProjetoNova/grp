﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

/**
 * Classe AtividadeEvolucao
 * */
namespace Negocio.Models
{
    public class AtividadeEvolucao : IEntidade
    {
        public int Id { get; set; }

        public int AtividadeId { get; set; }        
        
        public byte[] Anexo { get; set; }

        [ForeignKey("AtividadeId")]
        public Atividade Atividade { get; set; }
    }
}
