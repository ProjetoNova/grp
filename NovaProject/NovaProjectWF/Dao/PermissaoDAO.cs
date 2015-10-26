using NovaProjectWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Dao
{
    class PermissaoDAO : CRUD<PermissaoTipoUsuario>
    {
        public List<PermissaoTipoUsuario> GetPorTipoUsuario(int TipoUsuarioID)
        {
            List<PermissaoTipoUsuario> permissoes = new List<PermissaoTipoUsuario>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.PERMISSAO_ where c.TipoUsuarioId == TipoUsuarioID select c ;

                foreach (var item in query)
                {
                    permissoes.Add(item);
                }
            }

            return permissoes;
        }

    }
}
