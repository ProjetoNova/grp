using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models;
using NovaProjectWF.Dao;

namespace NovaProjectWF.Controllers.SessaoController
{
    public static class SessaoSistema
    {
        //usuario

        private static Int32 _usuarioId;
        private static String _nomeUsuario;
        private static String _loginUsuario;
        private static Boolean _admin;
        private static DateTime _dataHoraLogin;

        //get e set
        public static int UsuarioId
        {
            get { return SessaoSistema._usuarioId; }
            set { SessaoSistema._usuarioId = value; }
        }

        public static String NomeUsuario
        {
            get { return SessaoSistema._nomeUsuario; }
            set { SessaoSistema._nomeUsuario = value; }
        }

        public static String LoginUsuario
        {
            get { return SessaoSistema._loginUsuario; }
            set { SessaoSistema._loginUsuario = value; }
        }

        public static bool Administrador
        {
            get { return SessaoSistema._admin; }
            set { SessaoSistema._admin = value; }
        }

        public static DateTime DataHoraLogin
        {
            get { return SessaoSistema._dataHoraLogin; }
            set { SessaoSistema._dataHoraLogin = value; }
        }
    }
}