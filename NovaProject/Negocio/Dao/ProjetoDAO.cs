using Negocio.Models;
using Negocio.Models.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Dao
{
    public class ProjetoDAO : CRUD<Projeto>
    {
        public override List<Projeto> selectAll()
        {
            List<Projeto> allTipoUsuario = new List<Projeto>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.PROJETO_ select c;

                foreach (var item in query)
                {
                    allTipoUsuario.Add(item);
                }
            }

            return allTipoUsuario;
        }

        public List<Projeto> emAberto()
        {
            List<Projeto> tipoUsuario = new List<Projeto>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.PROJETO_
                            where c.Situacao == ESituacaoProjeto.INICIADO
                            || c.Situacao == ESituacaoProjeto.NAO_INICIADO
                            select c;

                foreach (var item in query)
                {
                    tipoUsuario.Add(item);
                }
            }

            return tipoUsuario;
        }

        public List<Projeto> selectNome(string nome)
        {
            List<Projeto> tipoUsuario = new List<Projeto>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.PROJETO_
                            where c.Titulo.Contains(nome)
                            select c;

                foreach (var item in query)
                {
                    tipoUsuario.Add(item);
                }
            }

            return tipoUsuario;
        }

    }
}
