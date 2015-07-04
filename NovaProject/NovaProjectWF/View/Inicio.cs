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
using NovaProjectWF.Controllers.SessaoController;

namespace NovaProjectWF.View
{
    public partial class Inicio : Form
    {
        private Projetos meusProjetos;
        private NovoProjeto novoProj;
        private Atividades atividades;

        public Inicio()
        {
            InitializeComponent();
            if (!SessaoSistema.Administrador)
            {
                btnProjetos.Visible = false;
                btnNovoProjeto.Visible = false;
            }
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result =
               Mensagem.Confirmacao("Fechar Sistema", "Tem certeza que deseja sair do Sistema?");
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNovoProjeto_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this.MdiParent, typeof(NovoProjeto)))
                novoProj = new NovoProjeto();

            Janela.Exibir(novoProj, this.MdiParent, true);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this.MdiParent, typeof(Projetos)))
                meusProjetos = new Projetos();

            Janela.Exibir(meusProjetos, this.MdiParent, true);
            this.Close();
        }

        private void btnVerProjetos_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this.MdiParent, typeof(Atividades)))
                atividades = new Atividades();

            Janela.Exibir(atividades, this.MdiParent, false);
            this.Close();
        }
    }
}
