using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;

namespace NovaProjectWF.Dao
{
    public abstract class CRUD<T>
             where T : IEntidade
    {
        protected string tabela = null;
        protected object classe = null;
        private Contexto contexto;

        public CRUD() {
            contexto = new Contexto();
        }

        public virtual void insert(T objeto)
        {
            Object objRetorno = null;

           objRetorno = contexto.Set(objeto.GetType()).Add(objeto);

           contexto.SaveChanges();
        }

        public virtual void select(int id) { 
            
        }
    }
}
