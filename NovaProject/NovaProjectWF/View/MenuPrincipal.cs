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
        //Telas do Sistema
        private CadastroUsuario cadUsuario;
        private CadastroTipoUsuario cadTipUsuario;
        private CadastroTipoAtividade cadTipoAtividade;
        private MeusProjetos meusProjetos;
        private NovoProjeto novoProj;
        private MinhaConta minhaConta;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {

            DialogResult result =
               Mensagem.Confirmacao("Fechar Sistema", "Tem certeza que deseja sair do Sistema?");
            if (result == DialogResult.Yes)
            {
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
            if (Janela.Fechada(cadUsuario))
                cadUsuario = new CadastroUsuario();

            Janela.Exibir(cadUsuario, this);
        }

        //Menu Cadastro de Tipo de Usuario
        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Janela.Fechada(cadTipUsuario)) 
                cadTipUsuario = new CadastroTipoUsuario();

            Janela.Exibir(cadTipUsuario, this);
        }

        //Menu Cadastro de Tipo de Atividade
        private void tipoAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Janela.Fechada(cadTipoAtividade))
                cadTipoAtividade = new CadastroTipoAtividade();

            Janela.Exibir(cadTipoAtividade, this);
        }
        
        //Menu Meus Projetos
        private void meusProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Janela.Fechada(meusProjetos))
                meusProjetos = new MeusProjetos();

            Janela.Exibir(meusProjetos, this);
        }

        //Menu Novo Projeto
        private void novoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Janela.Fechada(novoProj))
                novoProj = new NovoProjeto();

            Janela.Exibir(novoProj, this);
        }

        //Menu Minha Conta
        private void minhaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Janela.Fechada(minhaConta))
                minhaConta = new MinhaConta();

            Janela.Exibir(minhaConta, this);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //IMPLEMENTAR METODO DE LOGOUT
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

       
    }
}