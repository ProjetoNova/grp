using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Dao
{
    public class FaseProjetoDAO : CRUD<FaseProjeto>
    {
        public List<FaseProjeto> GetFasesDoProjeto(int ProjetoId)
        {
            List<FaseProjeto> fasesProjeto = new List<FaseProjeto>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.FASE_PROJETO_
                            where c.ProjetoId == ProjetoId
                            select c;

                foreach (var item in query)
                {
                    fasesProjeto.Add((FaseProjeto)item);
                }
            }

            return fasesProjeto;
        }

        public List<FaseProjeto> selectNome(int projetoId, string nome)
        {
            List<FaseProjeto> fasesProjeto = new List<FaseProjeto>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.FASE_PROJETO_
                            where c.Descricao == nome
                            && c.ProjetoId == projetoId
                            select c;

                foreach (var item in query)
                {
                    fasesProjeto.Add((FaseProjeto)item);
                }
            }

            return fasesProjeto;
        }

    }
}
