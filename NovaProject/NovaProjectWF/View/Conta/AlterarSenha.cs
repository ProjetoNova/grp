using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Controllers.SessaoController;
using NovaProjectWF.View.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaProjectWF.View.Conta
{
    public partial class AlterarSenha : Form
    {
        public AlterarSenha()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            LoginController control = new LoginController();

            if (txtSenhaNew.Text.Trim() != txtConfSenhaNew.Text.Trim())
            {
                Mensagem.Erro("Senhas não conferem!");
            }
            else if (!control.Login(SessaoSistema.LoginUsuario, txtSenhaOld.Text.Trim()))
            {
                Mensagem.Erro("Senha antiga incorreta!");
            }
            else
            {
                control.AlterarSenha(txtSenhaNew.Text.Trim());
                Mensagem.Informacao("Senha Alterada com Sucesso!");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
