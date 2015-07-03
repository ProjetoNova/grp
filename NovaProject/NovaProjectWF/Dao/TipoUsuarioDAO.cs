using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models;
using NovaProjectWF.Dao;

namespace NovaProjectWF.Dao
{
    class TipoUsuarioDAO : CRUD<TipoUsuario>
    {
        public override List<TipoUsuario> selectAll()
        {
            List<TipoUsuario> allTipoUsuario = new List<TipoUsuario>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.TIPO_USUARIO_ select c;

                foreach (var item in query)
                {
                    allTipoUsuario.Add(item);
                }
            }

            return allTipoUsuario;
        }

        public TipoUsuario selectNome(string nome)
        {
            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.TIPO_USUARIO_ 
                            where c.Nome == nome select c;

                foreach (var item in query)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
