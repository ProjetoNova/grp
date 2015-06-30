using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models;

namespace NovaProjectWF.Controllers.SessaoController
{
    class LoginController
    {
        //Login do Usuario
        public Sessao Login(string usuario, string senha)
        {
            Usuario usuarioLogin = null;

            //INSERIR AQUI UM METODO DE PESQUISA DE USUARIO NO BANCO

            Sessao sessaoAtiva = new Sessao();

            sessaoAtiva.Usuario = usuarioLogin;

            sessaoAtiva.HoraLogin = new DateTime();

            return sessaoAtiva;
        }

        //realiza logout do usuario
        public Sessao Logout(Sessao sessaoAtiva)
        {
            sessaoAtiva.Usuario = null;

            return sessaoAtiva;
        }

        //verifica se a sessao do usuario esta ativa
        public bool SessaoAtiva(Sessao sessao)
        {
            if (sessao.Usuario != null)
            {
                return true;
            }

            return false;
        }
    }
}
