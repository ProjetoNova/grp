using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaProjectWF.View.Cadastro;
using NovaProjectWF.View.Conta;
using NovaProjectWF.View.Projeto;

namespace NovaProjectWF.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadUsuario = new CadastroUsuario();

            cadUsuario.Show();
        }
    }
}
