using NovaProjectWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Dao
{
    class SituacaoAtividadeDAO: CRUD<SituacaoAtividade>
    {
        public override List<SituacaoAtividade> selectAll()
        {
            List<SituacaoAtividade> allSituacao = new List<SituacaoAtividade>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.SITUACAO_ATIVIDADE_ select c;

                foreach (var item in query)
                {
                    allSituacao.Add(item);
                }
            }

            return allSituacao;
        }

        public List<SituacaoAtividade> selectNome(string nome)
        {
            List<SituacaoAtividade> situacao = new List<SituacaoAtividade>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.SITUACAO_ATIVIDADE_
                            where c.Nome.Contains(nome)
                            select c;

                foreach (var item in query)
                {
                    situacao.Add(item);
                }
            }

            return situacao;
        }
    }
}
