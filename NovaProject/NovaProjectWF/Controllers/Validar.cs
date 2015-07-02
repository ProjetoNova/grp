using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Controllers
{
    class Validar
    {
        public static bool Numero(string valor)
        {
            try
            {
                Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

    }
}
