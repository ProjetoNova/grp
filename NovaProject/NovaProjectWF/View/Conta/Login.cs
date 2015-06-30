using System;
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
            else if(lControl.Login(txtUsuario.Text.Trim(),
                    txtSenha.Text.Trim()).Usuario == null)
            {
                Mensagem.Aviso("Usuario ou Senha Incorretos");
                txtSenha.Text = "";
                txtSenha.Focus();
            }
            else
            {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Visible = false;
            }
        }
    }
}
