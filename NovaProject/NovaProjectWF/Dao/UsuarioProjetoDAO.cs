using NovaProjectWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Dao
{
    class UsuarioProjetoDAO: CRUD<UsuarioProjeto>
    {
        public UsuarioProjeto GetUsuarioProjeto(int ProjetoId, int UsuarioId)
        {
            UsuarioProjeto usuarioProjeto = null;

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.USUARIO_PROJETO_
                            where c.ProjetoId == ProjetoId
                            && c.UsuarioId == UsuarioId
                            select c;

                foreach (var item in query)
                {
                    usuarioProjeto = (UsuarioProjeto)item;
                }
            }

            return usuarioProjeto;
        }

        public List<UsuarioProjeto> GetUsuariosDoProjeto(int ProjetoId)
        {
            List<UsuarioProjeto> usuariosProjeto = new List<UsuarioProjeto>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.USUARIO_PROJETO_
                            where c.ProjetoId == ProjetoId
                            select c;

                foreach (var item in query)
                {
                    usuariosProjeto.Add((UsuarioProjeto)item);
                }
            }

            return usuariosProjeto;
        }

        public List<UsuarioProjeto> GetProjetosDoUsuario(int UsuarioId)
        {
            List<UsuarioProjeto> usuariosProjeto = new List<UsuarioProjeto>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.USUARIO_PROJETO_
                            where c.UsuarioId == UsuarioId
                            select c;

                foreach (var item in query)
                {
                    usuariosProjeto.Add((UsuarioProjeto)item);
                }
            }

            return usuariosProjeto;
        }
    }
}
