using NovaProjectWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Dao
{
    class TipoAtvidadeDAO: CRUD<TipoAtividade>
    {
        public override List<TipoAtividade> selectAll()
        {
            List<TipoAtividade> allTipoAtividade = new List<TipoAtividade>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.TIPO_ATIVIDADE_ select c;

                foreach (var item in query)
                {
                    allTipoAtividade.Add(item);
                }
            }

            return allTipoAtividade;
        }

        public List<TipoAtividade> selectNome(string nome)
        {
            List<TipoAtividade> tipoAtividade = new List<TipoAtividade>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.TIPO_ATIVIDADE_
                            where c.Nome.Contains(nome)
                            select c;

                foreach (var item in query)
                {
                    tipoAtividade.Add(item);
                }
            }

            return tipoAtividade;
        }
    }
}
