using System;
using System.Collections.Generic;
using System.Globalization;
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

        public static bool SenhasConferem(string senha1, string senha2)
        {
            if (senha1 != string.Empty && senha2 != string.Empty)
            {
                if (senha1 == senha2)
                {
                    return true;
                }
            }
            return false;
        }

        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        public static Double HoraToDouble(string hora)
        {
            string tratar = hora.Replace(":", "");

            return Convert.ToDouble(tratar);
        }

        public static string DoubleToHora(double horaDouble)
        {
            string hora = horaDouble.ToString().Remove(2);
            string minuto = horaDouble.ToString().Substring(0, 2);

            return hora + ":" + minuto;
        }
    }
}
