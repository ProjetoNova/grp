using NovaProjectWF.Controllers;
using NovaProjectWF.Controllers.ProjetoController;
using NovaProjectWF.Models.Enumerados;
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
using NovaProjectWF.Models;
using NovaProjectWF.Dao;
using NovaProjectWF.Controllers.CadastroController;

namespace NovaProjectWF.View.Projeto
{
    public partial class NovoProjeto : Form
    {
        Models.Projeto projeto;
        List<Models.FaseProjeto> fases;
        List<Models.Atividade> atividades;

        public NovoProjeto()
        {
            InitializeComponent();
            cbSituacao.DataSource = SituacaoProjeto.GetList();
            UsuarioController controlUser = new UsuarioController();
            TipoUsuarioController controlTUsuario = new TipoUsuarioController();
            cbUsuario.DataSource = controlUser.TodosOsNomes();
            cbPapel.DataSource = controlTUsuario.TodosOsNomes();

            if (lblId.Text.Trim() == string.Empty)
            {
                cbPapel.Enabled = false;
                cbUsuario.Enabled = false;
                btnIncluirUsuario.Enabled = false;
                btnExcluirUsuario.Enabled = false;
                ((Control)tabFase).Enabled = false;
                //((Control)tabAnexos).Enabled = false;
            }

            AtivaDesativaCampos();
        }

        public void Exibir(Form parent, Object projeto)
        {
            this.projeto = (Models.Projeto)projeto;

            lblId.Text = this.projeto.Id+"";
            txtNome.Text = this.projeto.Titulo;
            txtDescricao.Text = this.projeto.Descricao;
            txtPlanoProjeto.Rtf = Validar.GetString(this.projeto.PlanoProjeto);
            cbSituacao.SelectedIndex = SituacaoProjeto.GetIndex(this.projeto.Situacao);
            dtInicio.Value = this.projeto.DataInicio;
            dtPrevista.Value = this.projeto.DataPrevisao;
            dtFim.Text = this.projeto.DataConclusao + "";

            this.Text = "Projeto - " + this.projeto.Titulo;

            if(Janela.Fechada(parent, this.GetType())) {
                Janela.Exibir(this, parent, false);
            }
            else {
                Janela.JanelaAberta(parent, this.GetType()).Close();
                Janela.Exibir(this, parent, false);
            }
            UsuarioProjetoController control = new UsuarioProjetoController();
            gridEquipe.DataSource = null;
            gridEquipe.DataSource = control.GetUsuariosDoProjeto(Convert.ToInt32(lblId.Text.Trim()));

            gridFasesRefresh();
            AtivaDesativaCampos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProjetoController control = new ProjetoController();

            Object retorno = control.Salvar(lblId.Text.Trim(), txtNome.Text.Trim(), txtDescricao.Text.Trim(),
                Convert.ToDateTime(dtInicio.Value), Convert.ToDateTime(dtPrevista.Value), Validar.GetBytes(txtPlanoProjeto.Rtf), 
                Convert.ToDateTime(DateTime.Now), 
                SituacaoProjeto.GetEnum(cbSituacao.SelectedValue.ToString()));

            if (retorno == null)
            {
                Mensagem.Erro("Não foi possível Salvar");
            }
            else if (retorno.GetType().Equals(typeof(Int32)))
            {
                if (Convert.ToInt32(retorno) <= 0)
                {
                    Mensagem.Erro("Nenhuma alteração a fazer");
                }
                else
                {
                    Mensagem.Informacao("Salvo com sucesso");
                }
            }
            else
            {
                lblId.Text = ((Models.Projeto)retorno).Id + "";
                Mensagem.Informacao("Salvo com sucesso");
                projeto = (Models.Projeto)retorno;
                AtivaDesativaCampos();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoProjeto novo = new NovoProjeto();
            Janela.Exibir(novo, this.MdiParent, true);
            this.Close();
            AtivaDesativaCampos();
        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDAO uDao = new UsuarioDAO();
            TipoUsuarioDAO tuDao = new TipoUsuarioDAO();
            Usuario u = uDao.selectNome(cbUsuario.SelectedItem.ToString())[0];
            TipoUsuario tu = tuDao.selectNome(cbPapel.SelectedItem.ToString())[0];
            UsuarioProjetoController control = new UsuarioProjetoController();

            control.Salvar(tu.Id, Convert.ToInt32(lblId.Text.Trim()), u.Id);

            gridEquipe.DataSource = null;
            gridEquipe.DataSource = control.GetUsuariosDoProjeto(Convert.ToInt32(lblId.Text.Trim()));

        }

        private void btnNovaFase_Click(object sender, EventArgs e)
        {
            FaseProjeto fase = new FaseProjeto(this);

            fase.ExibirNova(this.MdiParent, this.projeto);
        }

        public void AtivaDesativaCampos()
        {
            if (lblId.Text.Trim() == string.Empty)
            {
                cbPapel.Enabled = false;
                cbUsuario.Enabled = false;
                btnIncluirUsuario.Enabled = false;
                btnExcluirUsuario.Enabled = false;
                ((Control)tabFase).Enabled = false;
                //((Control)tabAnexos).Enabled = false;
            }
            else
            {
                cbPapel.Enabled = true;
                cbUsuario.Enabled = true;
                btnIncluirUsuario.Enabled = true;
                btnExcluirUsuario.Enabled = true;
                ((Control)tabFase).Enabled = true;
               // ((Control)tabAnexos).Enabled = true;
            }
        }

        public void gridFasesRefresh()
        {
            FaseProjetoController fControl = new FaseProjetoController();
            fases = fControl.GetFasesDoProjeto(Convert.ToInt32(lblId.Text.Trim()));
            gridFase.DataSource = null;
            gridFase.DataSource = fases;

            this.gridFase.Columns["ProjetoId"].Visible = false;
            this.gridFase.Columns["Projeto"].Visible = false;
            this.gridFase.Columns["Id"].Visible = false;
        }

        public void gridAtividadesRefresh()
        {
            if (gridFase.SelectedRows.Count > 0)
            {
                AtividadeController aControl = new AtividadeController();
                atividades = aControl.GetAtividadesDaFase(fases[gridFase.SelectedRows[0].Index].Id);
                gridAtividade.DataSource = null;
                gridAtividade.DataSource = atividades;
                gridAtividade.Refresh();

                this.gridAtividade.Columns["FaseProjetoId"].Visible = false;
                this.gridAtividade.Columns["UsuarioId"].Visible = false;
                this.gridAtividade.Columns["TipoAtividadeId"].Visible = false;
                this.gridAtividade.Columns["FaseProjeto"].Visible = false;
                this.gridAtividade.Columns["Colaborador"].Visible = false;
                this.gridAtividade.Columns["TipoAtividade"].Visible = false;
                this.gridAtividade.Columns["Anexos"].Visible = false;
                this.gridAtividade.Columns["Descricao"].Visible = false;
                this.gridAtividade.Columns["TempoEstimado"].Visible = false;
                this.gridAtividade.Columns["TempoGasto"].Visible = false;
                this.gridAtividade.Columns["SituacaoAtividadeId"].Visible = false;
                this.gridAtividade.Columns["SituacaoAtividadeId"].Visible = false;
            }
        }

        private void btnEditarFase_Click(object sender, EventArgs e)
        {
            if (gridFase.SelectedRows.Count > 0)
            {
                FaseProjeto fase = new FaseProjeto(this);

                Models.FaseProjeto fase_ = fases[gridFase.SelectedRows[0].Index];
                fase_.Projeto = projeto;
                fase.Exibir(this.MdiParent, fase_);
            }
        }

        private void btnAtividade_Click(object sender, EventArgs e)
        {
            if (gridFase.SelectedRows.Count > 0)
            {
                NovaAtividade atv = new NovaAtividade(this, Convert.ToInt32(lblId.Text.Trim()));

                Models.FaseProjeto fase = fases[gridFase.SelectedRows[0].Index];
                fase.Projeto = projeto;
                atv.ExibirNova(this.MdiParent, fase);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridAtividade.SelectedRows.Count > 0)
            {
                NovaAtividade atv = new NovaAtividade(this, Convert.ToInt32(lblId.Text.Trim()));

                Atividade atv_ = atividades[gridAtividade.SelectedRows[0].Index];
                //atv_.FaseProjeto = fases[gridFase.SelectedRows[0].Index];
                //atv_.FaseProjeto.Projeto = projeto;
                atv.Exibir(this.MdiParent, atv_);
            }
        }

        private void gridFase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridAtividadesRefresh();
        }
    }
}