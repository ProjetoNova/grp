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
            DialogResult result = Mensagem.Confirmacao();
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //INSERIR UM METODO DE LOGIN AQUI

            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;
        }
    }
}
