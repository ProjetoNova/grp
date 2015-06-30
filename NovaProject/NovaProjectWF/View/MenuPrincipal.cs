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
using NovaProjectWF.View.Utilitarios;

namespace NovaProjectWF.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //sobrescrita do método onClosed
        protected override void OnClosed(EventArgs e)
        {
            DialogResult result = 
                Mensagem.Confirmacao("Fechar Sistema", "Tem certeza que deseja sair do Sistema?");
            if (result == DialogResult.Yes)
            {
                base.OnClosed(e);
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
               //nao ta funcionando
            }
        }

        //Menu Cadastro de Usuario
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadUsuario = new CadastroUsuario();

            cadUsuario.Show();
        }

        //Menu Cadastro de Tipo de Usuario
        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroTipoUsuario cadTipUsuario = new CadastroTipoUsuario();

            cadTipUsuario.Show();
        }

        //Menu Cadastro de Tipo de Atividade
        private void tipoAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroTipoAtividade cadTipoAtividade = new CadastroTipoAtividade();

            cadTipoAtividade.Show();
        }


        
    }
}