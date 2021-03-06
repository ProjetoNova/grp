﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaProjectWF.View.Utilitarios;
using NovaProjectWF.Controllers.SessaoController;
using NovaProjectWF.Controllers.CadastroController;
using Negocio.Models;

namespace NovaProjectWF.View.Conta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = Mensagem.Confirmacao("Sair", "Você deseja sair do sistema?");
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length > 0)
            {
                UsuarioController uControl = new UsuarioController();

                List<Usuario> usuarios = uControl.BuscarPorNome(txtUsuario.Text.Trim());

                if (usuarios.Count > 0)
                {
                    Usuario u = uControl.BuscarPorNome(txtUsuario.Text.Trim()).First();

                    txtUsuario.Text = u.Login;
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginController lControl = new LoginController();

            if (txtUsuario.Text.Trim() == string.Empty)
            {
                Mensagem.Aviso("Usuario nao pode ser vazio!");
                txtUsuario.Focus();
            }
            else if (txtSenha.Text.Trim() == string.Empty)
            {
                Mensagem.Aviso("Senha nao pode ser vazio!");
                txtSenha.Focus();
            }
            
            else if(!lControl.Login(txtUsuario.Text.Trim(),
                    txtSenha.Text.Trim()))
            {
                Mensagem.Aviso("Usuario ou Senha Incorretos");
                txtSenha.Text = "";
                txtSenha.Focus();
            }
            else
            {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Text = menu.Text + " - " + SessaoSistema.NomeUsuario;
                menu.Show();
                this.Visible = false;
            }
        }
    }
}
