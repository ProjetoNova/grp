using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models;
using Negocio.Dao;
using NovaProjectWF.Controllers.CadastroController;

namespace NovaProjectWF.Controllers.SessaoController
{
    class LoginController
    {

        UsuarioDAO crud;

        public LoginController()
        {
            crud = new UsuarioDAO();
        }

        //Login do Usuario
        public bool Login(string usuario, string senha)
        {
            Usuario usuarioLogin = null;

            TipoUsuarioController control = new TipoUsuarioController();
            usuarioLogin = crud.login(usuario, senha);

            if (usuarioLogin == null)
            {
                return false;
            }

            List<PermissaoTipoUsuario> permissao = control.BuscarPorTipoDeUsuario(usuarioLogin.TipoUsuarioId);

            SessaoSistema.Administrador = (control.BuscarPorId(
                                            usuarioLogin.TipoUsuarioId+"").Administrador || usuarioLogin.Master);
            SessaoSistema.LoginUsuario = usuarioLogin.Login;
            SessaoSistema.NomeUsuario = usuarioLogin.Nome;
            SessaoSistema.UsuarioId = usuarioLogin.Id;
            SessaoSistema.DataHoraLogin = Convert.ToDateTime(DateTime.Now);

            return true;
        }

        //realiza o login direto com o login usuario
        public bool Login(string senha)
        {
            Usuario usuarioLogin = null;

            TipoUsuarioController control = new TipoUsuarioController();
            usuarioLogin = crud.login("sistema", senha);

            if (usuarioLogin == null)
            {
                return false;
            }

            return true;
        }

        //realiza logout do usuario
        public void Logout()
        {
            SessaoSistema.Administrador = false;
            SessaoSistema.LoginUsuario = null;
            SessaoSistema.NomeUsuario = null;
            SessaoSistema.UsuarioId = 0;
        }

        //verifica se a sessao do usuario esta ativa
        public bool SessaoAtiva()
        {
            if (SessaoSistema.UsuarioId != 0)
            {
                return true;
            }

            return false;
        }

        internal void AlterarSenha(string senha)
        {
            Usuario usuario = (Usuario)crud.select(SessaoSistema.UsuarioId);
            usuario.Senha = senha;
            crud.save(SessaoSistema.UsuarioId, usuario);
        }
    }
}
