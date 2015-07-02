using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models.Interfaces;
using System.Data.Entity;

namespace NovaProjectWF.Dao
{
    public abstract class CRUD<T>
             where T : IEntidade
    {
        private Contexto contexto { get; set; }

        public CRUD() {
            contexto = new Contexto();
        }

        public virtual Object insert(T objeto)
        {
            Object objRetorno = null;

            objRetorno = contexto.Set(typeof(T)).Add(objeto);

            contexto.SaveChanges();

            return objRetorno;
        }

        public virtual Object select(int Id) 
        {
            Object objRetorno = null;

            objRetorno = contexto.Set(typeof(T)).Find(Id);

            return objRetorno;
        }

        public virtual List<T> selectAll()
        {
            

            return null;
        }

        public virtual int update(int Id, T newObj)
        {
            newObj.Id = ((T)select(Id)).Id;

            contexto.Entry(select(Id)).CurrentValues.SetValues(newObj);

            int result = contexto.SaveChanges();

            return result;
        }

        public virtual Object save(string Id, T newObj)
        {
            Object objRetorno = null;

            if (Id != string.Empty)
            {
                objRetorno = select(Convert.ToInt32(Id));
            }

            if (objRetorno == null)
            {
                objRetorno = insert(newObj);
            }
            else
            {
                objRetorno = update(Convert.ToInt32(Id), newObj);
            }

            return objRetorno;
        }

        public Object getContexto()
        {
            return this.contexto;
        }
    }
}
