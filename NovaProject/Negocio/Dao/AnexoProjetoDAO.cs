using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Dao
{
    public class AnexoProjetoDAO : CRUD<AnexoProjeto>

    {
        public List<AnexoProjeto> GetArtefatosDoProjeto(int ProjetoId)
        {
            List<AnexoProjeto> artefatos = new List<AnexoProjeto>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.ANEXO_PROJETO_
                            where c.ProjetoId == ProjetoId
                            select c;

                foreach (var item in query)
                {
                    artefatos.Add((AnexoProjeto)item);
                }
            }

            return artefatos;
        }
    }
}
