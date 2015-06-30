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
        private Inicio inicio;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //Sobrescrita do Metodo OnClosing
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
                e.Cancel = true;
            }
        }

        //Menu Cadastro de Usuario
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(CadastroUsuario)))
                cadUsuario = new CadastroUsuario();

            Janela.Exibir(cadUsuario, this);
        }

        //Menu Cadastro de Tipo de Usuario
        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(CadastroTipoUsuario))) 
                cadTipUsuario = new CadastroTipoUsuario();

            Janela.Exibir(cadTipUsuario, this);
        }

        //Menu Cadastro de Tipo de Atividade
        private void tipoAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(CadastroTipoAtividade)))
                cadTipoAtividade = new CadastroTipoAtividade();

            Janela.Exibir(cadTipoAtividade, this);
        }
        
        //Menu Meus Projetos
        private void meusProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(MeusProjetos)))
                meusProjetos = new MeusProjetos();

            Janela.Exibir(meusProjetos, this);
        }

        //Menu Novo Projeto
        private void novoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(NovoProjeto)))
                novoProj = new NovoProjeto();

            Janela.Exibir(novoProj, this);
        }

        //Menu Minha Conta
        private void minhaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(MinhaConta)))
                minhaConta = new MinhaConta();

            Janela.Exibir(minhaConta, this);
        }

        //Menu de Inicio
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(Inicio)))
                inicio = new Inicio();

            Janela.Exibir(inicio, this);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //IMPLEMENTAR METODO DE LOGOUT
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            inicio = new Inicio();

            Janela.Exibir(inicio, this);
        }

        
    }
}