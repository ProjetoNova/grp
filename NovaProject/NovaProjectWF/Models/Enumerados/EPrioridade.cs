using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Models.Enumerados
{
    enum EPrioridade
    {
        MUITO_BAIXA,
        BAIXA,
        NORMAL,
        ALTA,
        MUITO_ALTA,
        URGENTE
    }

    class Prioridade
    {
        //retorna em formato de lista
        public static List<string> GetList()
        {
            List<string> lista = new List<string>();

            lista.Add("Muito Baixa");
            lista.Add("Baixa");
            lista.Add("Normal");
            lista.Add("Alta");
            lista.Add("Muito Alta");
            lista.Add("Urgente");

            return lista;
        }

        public static string GetValue(EPrioridade prioridade)
        {
            string ret = "";

            switch (prioridade)
            {
                case EPrioridade.MUITO_BAIXA:
                    ret = "Muito Baixa";
                    break;
                case EPrioridade.BAIXA:
                    ret = "Baixa";
                    break;
                case EPrioridade.NORMAL:
                    ret = "Normal";
                    break;
                case EPrioridade.ALTA:
                    ret = "Alta";
                    break;
                case EPrioridade.MUITO_ALTA:
                    ret = "Muito Alta";
                    break;
                case EPrioridade.URGENTE:
                    ret = "Urgente";
                    break;
                default:
                    break;
            }

            return ret;
        }

        //retorna o index
        public static int GetIndex(EPrioridade prioridade)
        {
            int ret = 0;

            switch (prioridade)
            {
                case EPrioridade.MUITO_BAIXA:
                    ret = 0;
                    break;
                case EPrioridade.BAIXA:
                    ret = 1;
                    break;
                case EPrioridade.NORMAL:
                    ret = 2;
                    break;
                case EPrioridade.ALTA:
                    ret = 3;
                    break;
                case EPrioridade.MUITO_ALTA:
                    ret  = 4;
                    break;
                case EPrioridade.URGENTE:
                    ret = 5;
                    break;
                default:
                    break;
            }

            return ret;
        }

        //retorna em formato de enum
        public static EPrioridade GetEnum(string value)
        {
            if (value.Equals("Muito Baixa"))
            {
                return EPrioridade.MUITO_ALTA;
            }

            if (value.Equals("Baixa"))
            {
                return EPrioridade.BAIXA;
            }

            if (value.Equals("Normal"))
            {
                return EPrioridade.NORMAL;
            }

            if (value.Equals("Alta"))
            {
                return EPrioridade.ALTA;
            }

            if (value.Equals("Muito Alta"))
            {
                return EPrioridade.MUITO_ALTA;
            }

            return EPrioridade.URGENTE;
        }
    }

}
