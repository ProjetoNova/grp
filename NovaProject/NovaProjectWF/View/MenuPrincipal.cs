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
using NovaProjectWF.View.Conta;
using NovaProjectWF.View.Projeto;
using NovaProjectWF.View.Cadastro;
using NovaProjectWF.Dao;
using NovaProjectWF.Controllers.SessaoController;
namespace NovaProjectWF.View
{
    public partial class MenuPrincipal : Form
    {
        //Telas do Sistema
        private CadastroUsuario cadUsuario;
        private CadastroTipoUsuario cadTipUsuario;
        private CadastroTipoAtividade cadTipoAtividade;
        private Projetos meusProjetos;
        private NovoProjeto novoProj;
        private MinhaConta minhaConta;
        private Inicio inicio;
        private Sobre sobre;
        private AlterarSenha alterarSenha;
        private SituacaoAtividade situacao;
        private Atividades atividades;

        public MenuPrincipal()
        {
            InitializeComponent();

            if (!SessaoSistema.Administrador)
            {
                cadastroToolStripMenuItem.Visible = false;
                novoProjetoToolStripMenuItem.Visible = false;
            }
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        //Menu Cadastro de Usuario
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(CadastroUsuario)))
                cadUsuario = new CadastroUsuario();

            Janela.Exibir(cadUsuario, this, true);
        }

        //Menu Cadastro de Tipo de Usuario
        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(CadastroTipoUsuario))) 
                cadTipUsuario = new CadastroTipoUsuario();

            Janela.Exibir(cadTipUsuario, this, true);
        }

        //Menu Cadastro de Tipo de Atividade
        private void tipoAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(CadastroTipoAtividade)))
                cadTipoAtividade = new CadastroTipoAtividade();

            Janela.Exibir(cadTipoAtividade, this, true);
        }
        
        //Menu Projetos
        private void meusProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(Projetos)))
                meusProjetos = new Projetos();

            Janela.Exibir(meusProjetos, this, false);
        }

        //Menu Novo Projeto
        private void novoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(NovoProjeto)))
                novoProj = new NovoProjeto();

            Janela.Exibir(novoProj, this, true);
        }

        //Menu Minha Conta
        private void minhaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(MinhaConta)))
                minhaConta = new MinhaConta();

            Janela.Exibir(minhaConta, this, false);
        }

        //Menu de Inicio
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(Inicio)))
                inicio = new Inicio();

            Janela.Exibir(inicio, this, false);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            inicio = new Inicio();

            Janela.Exibir(inicio, this, false);
        }

        //janela sobre
        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(Sobre)))
                sobre = new Sobre();

            Janela.Exibir(sobre, this, false);
        }

        //menu alterar senha
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(AlterarSenha)))
                alterarSenha = new AlterarSenha();

            Janela.Exibir(alterarSenha, this, false);
        }

        //menu situacao atividade
        private void situaçãoAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(SituacaoAtividade)))
                situacao = new SituacaoAtividade();

            Janela.Exibir(situacao, this, true);
        }

        //menu atividades
        private void minhasAtividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this, typeof(Atividades)))
                atividades = new Atividades();

            Janela.Exibir(atividades, this, false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeStatus.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
               // DateTime.Now.ToShortDateString() +" "+ 
        }

        private void visualizarEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaximizarTudo();
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaximizarTudo();
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaximizarTudo();
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void minimizarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.WindowState == FormWindowState.Normal ||
                    form.WindowState == FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void restaurarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaximizarTudo();
        }

        private void MaximizarTudo()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.WindowState == FormWindowState.Minimized ||
                    form.WindowState == FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void fecharTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

    }
}