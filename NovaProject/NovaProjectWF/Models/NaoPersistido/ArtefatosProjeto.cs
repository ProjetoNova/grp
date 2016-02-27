using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Models.NaoPersistido
{
    class ArtefatosProjeto
    {
        public int IdAnexo { get; set; }
        public string NomeArquivo { get; set; }
        public float TamanhoArquivo { get; set; }
        public DateTime DataArquivo { get; set; }
        public string Responsavel { get; set; }
        public string Projeto { get; set; }
        public string Observacoes { get; set; }

    }
}
