using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Models;
using Negocio.Dao;

namespace NovaProjectWeb.Controller.SessaoController
{
    public static class SessaoSistema
    {
        //usuario
        private static Int32 _usuarioId;
        private static String _nomeUsuario;
        private static String _loginUsuario;
        private static Boolean _admin;
        private static DateTime _dataHoraLogin;
        private static Boolean _cadUsuario;
        private static Boolean _cadTipoUsuario;
        private static Boolean _cadSitAtividade;
        private static Boolean _cadTipoAtividade;
        private static Boolean _novoProjeto;
        private static Boolean _novoFaseProjeto;
        private static Boolean _novoAtividade;

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

        public static bool CadUsuario
        {
            get { return SessaoSistema._cadUsuario; }
            set { SessaoSistema._cadUsuario = value; }
        }

        public static bool CadTipoUsuario
        {
            get { return SessaoSistema._cadTipoUsuario; }
            set { SessaoSistema._cadTipoUsuario = value; }
        }

        public static bool CadSitAtividade
        {
            get { return SessaoSistema._cadSitAtividade; }
            set { SessaoSistema._cadSitAtividade = value; }
        }

        public static bool CadTipoAtividade
        {
            get { return SessaoSistema._cadTipoAtividade; }
            set { SessaoSistema._cadTipoAtividade = value; }
        }

        public static bool NovoProjeto
        {
            get { return SessaoSistema._novoProjeto; }
            set { SessaoSistema._novoProjeto = value; }
        }

        public static bool NovoFaseProjeto
        {
            get { return SessaoSistema._novoFaseProjeto; }
            set { SessaoSistema._novoFaseProjeto = value; }
        }

        public static bool NovoAtividade
        {
            get { return SessaoSistema._novoAtividade; }
            set { SessaoSistema._novoAtividade = value; }
        }
    }
}