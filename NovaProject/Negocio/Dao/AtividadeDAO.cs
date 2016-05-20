using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Dao
{
    public class AtividadeDAO : CRUD<Atividade>
    {
        public List<Atividade> GetAtividadesDaFase(int FaseProjetoId)
        {
            List<Atividade> atividades = new List<Atividade>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.ATIVIDADE_
                            where c.FaseProjetoId == FaseProjetoId
                            select c;

                foreach (var item in query)
                {
                    atividades.Add((Atividade)item);
                }
            }

            return atividades;
        }

        public List<Atividade> AtividadesAgrupPorUsuario()
        {
            List<Atividade> atividades = new List<Atividade>();

            DateTime now = DateTime.Now;

            DateTime nowMinus30Days = now.AddDays(-30);

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.ATIVIDADE_
                            where c.DataFim >= nowMinus30Days
                            orderby c.TipoAtividadeId, c.DataFim descending
                            select c;

                foreach (var item in query)
                {
                    atividades.Add((Atividade)item);
                }
            }

            return atividades;
        }

        public List<Atividade> AtividadesAbertaPorUsuario()
        {
            List<Atividade> atividades = new List<Atividade>();
        
            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.ATIVIDADE_
                            where c.DataFim == null
                            orderby c.TipoAtividadeId, c.DataFim descending
                            select c;

                foreach (var item in query)
                {
                    atividades.Add((Atividade)item);
                }
            }

            return atividades;
        }

        public List<Atividade> selectPorSituacao(SituacaoAtividade atv)
        {
            List<Atividade> atividades = new List<Atividade>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.ATIVIDADE_
                            where c.SituacaoAtividadeId == atv.Id
                            select c;

                foreach (var item in query)
                {
                    atividades.Add((Atividade)item);
                }
            }

            return atividades;
        }

        public List<Atividade> selectPorNomeOuDescrica(string valor)
        {
            List<Atividade> atividades = new List<Atividade>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.ATIVIDADE_
                            where c.Titulo.Contains(valor)
                            || c.Descricao.Contains(valor)
                            select c;

                foreach (var item in query)
                {
                    atividades.Add((Atividade)item);
                }
            }

            return atividades;
        }
    }
}
