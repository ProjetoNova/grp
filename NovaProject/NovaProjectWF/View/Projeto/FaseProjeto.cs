using NovaProjectWF.Controllers.ProjetoController;
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

namespace NovaProjectWF.View.Projeto
{
    public partial class FaseProjeto : Form
    {
        Models.FaseProjeto faseProjeto;
        NovoProjeto proj;

        public FaseProjeto(Object janelaProjeto)
        {
            InitializeComponent();
            proj = (NovoProjeto)janelaProjeto;
        }

        private void AtualizaProjeto()
        {
            proj.gridFasesRefresh();
        }

        protected override void OnClosed(EventArgs e)
        {
            AtualizaProjeto();
            //proj.Focus();
            base.OnClosed(e);
        }

        public void Exibir(Form parent, Object faseProjeto)
        {
            this.faseProjeto = (Models.FaseProjeto) faseProjeto;

            this.lblId.Text = this.faseProjeto.Id+"";
            this.txtProjeto.Text = this.faseProjeto.Projeto.Titulo;
            this.txtDescricao.Text = this.faseProjeto.Descricao;
            this.dtInicio.Value = this.faseProjeto.DataInicio;
            this.dtFim.Value = this.faseProjeto.DataFim;
            this.dtInicio.MinDate = this.faseProjeto.Projeto.DataInicio;
            this.dtInicio.MaxDate = this.faseProjeto.Projeto.DataPrevisao;
            this.dtFim.MinDate = this.faseProjeto.Projeto.DataInicio;
            this.dtFim.MaxDate = this.faseProjeto.Projeto.DataPrevisao;

            if (Janela.Fechada(parent, this.GetType())) {
                Janela.Exibir(this, parent, true);
            }
            else
            {
                Janela.JanelaAberta(parent, this.GetType()).Close();
                Janela.Exibir(this, parent, true);
            }
        }

        public void ExibirNova(Form parent, Object projeto)
        {
            this.faseProjeto = new Models.FaseProjeto();

            this.faseProjeto.Projeto = (Models.Projeto)projeto;

            this.txtProjeto.Text = this.faseProjeto.Projeto.Titulo;

            this.dtInicio.MinDate = this.faseProjeto.Projeto.DataInicio;
            this.dtInicio.MaxDate = this.faseProjeto.Projeto.DataPrevisao;
            this.dtFim.MinDate = this.faseProjeto.Projeto.DataInicio;
            this.dtFim.MaxDate = this.faseProjeto.Projeto.DataPrevisao;

            if (Janela.Fechada(parent, this.GetType()))
            {
                Janela.Exibir(this, parent, true);
            }
            else
            {
                Janela.JanelaAberta(parent, this.GetType()).Close();
                Janela.Exibir(this, parent, true);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FaseProjetoController control = new FaseProjetoController();
            ProjetoController pControl = new ProjetoController();

            Object obj = control.NovaFase(lblId.Text.Trim(), this.faseProjeto.Projeto.Id,
                txtDescricao.Text.Trim(), Convert.ToDateTime(dtInicio.Value), 
                Convert.ToDateTime(dtFim.Value), checkAtivo.Checked);

            if (obj == null)
            {
                Mensagem.Erro("Não foi possível salvar!");
            }
            else if (obj.GetType().Equals(typeof(Int32)))
            {
                if (Convert.ToInt32(obj) <= 0)
                {
                    Mensagem.Erro("Nenhuma alteração a fazer");
                }
                else
                {
                    Mensagem.Informacao("Salvo com sucesso");
                    this.Close();
                }
            }
            else
            {
                lblId.Text = ((Models.FaseProjeto)obj).Id + "";
                Mensagem.Informacao("Salvo com sucesso");
                this.Close();
            }
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            lblId.Text = "";
            txtDescricao.Text = "";
            dtInicio.Text = DateTime.Today.ToString();
            dtFim.Text = DateTime.Today.ToString();
        }
    }
}
