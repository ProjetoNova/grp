using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Models.Enumerados
{
    enum ESituacaoProjeto
    {
        NAO_INICIADO,
        INICIADO,
        CONCLUIDO,
        CANCELADO
    }

    class SituacaoProjeto
    {
        //retorna em formato de lista
        public static List<string> GetList()
        {
            List<string> lista = new List<string>();

            lista.Add("Não Iniciado");
            lista.Add("Iniciado");
            lista.Add("Concluído");
            lista.Add("Cancelado");

            return lista;
        }

        //retorna o index
        public static int GetIndex(ESituacaoProjeto situacao)
        {
            int ret = 0;
            switch (situacao)
            {
                case ESituacaoProjeto.NAO_INICIADO:
                    ret = 0;
                    break;
                case ESituacaoProjeto.INICIADO:
                    ret = 1;
                    break;
                case ESituacaoProjeto.CONCLUIDO:
                    ret = 2;
                    break;
                case ESituacaoProjeto.CANCELADO:
                    ret = 3;
                    break;
                default:
                    break;
            }
            return ret;
        }

        //retorna em formato de enum
        public static ESituacaoProjeto GetEnum(string value)
        {
            if (value.Equals("Não Iniciado"))
            {
                return ESituacaoProjeto.NAO_INICIADO;
            }

            if (value.Equals("Iniciado"))
            {
                return ESituacaoProjeto.INICIADO;
            }

            if (value.Equals("Concluído"))
            {
                return ESituacaoProjeto.CONCLUIDO;
            }

            return ESituacaoProjeto.CANCELADO;
        }
    }

}
