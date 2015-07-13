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
using NovaProjectWF.Controllers.SessaoController;
using NovaProjectWF.Models.NaoPersistido;

namespace NovaProjectWF.View.Projeto
{
    public partial class NovoProjeto : Form
    {
        Models.Projeto projeto;
        List<Models.FaseProjeto> fases;
        List<EquipeProjeto> equipe;
        List<AtividadeProjeto> atividades;

        public NovoProjeto()
        {
            InitializeComponent();
            cbSituacao.DataSource = SituacaoProjeto.GetList();
            UsuarioController controlUser = new UsuarioController();
            TipoUsuarioController controlTUsuario = new TipoUsuarioController();
            cbUsuario.DataSource = controlUser.TodosOsNomes();
            cbPapel.DataSource = controlTUsuario.TodosOsNomes();

            AtivaDesativaCampos();
        }

        //Metodo para Exibir um Projeto Ja existente
        public void Exibir(Form parent, Object projeto)
        {
            //atribui os valores
            this.projeto = (Models.Projeto)projeto;
            lblId.Text = this.projeto.Id+"";
            txtNome.Text = this.projeto.Titulo;
            txtDescricao.Text = this.projeto.Descricao;
            txtPlanoProjeto.Rtf = Validar.GetString(this.projeto.PlanoProjeto);
            cbSituacao.SelectedIndex = SituacaoProjeto.GetIndex(this.projeto.Situacao);
            dtInicio.Text = this.projeto.DataInicio+"";
            dtPrevista.Text = this.projeto.DataPrevisao+"";

            if (this.projeto.DataConclusao != default(DateTime) ||
                this.projeto.DataConclusao != null)
            {
                dtFim.Text = this.projeto.DataConclusao + "";
            }
            this.Text = "Projeto - " + this.projeto.Titulo;

            if(Janela.Fechada(parent, this.GetType())) {
                Janela.Exibir(this, parent, false);
            }
            else {
                Janela.JanelaAberta(parent, this.GetType()).Close();
                Janela.Exibir(this, parent, false);
            }
            //preenche a grid de equipe
            UsuarioProjetoController control = new UsuarioProjetoController();
            AtualizaGridEquipe(control);
            //atualiza grid fases
            gridFasesRefresh();
            //ativa os campos 
            AtivaDesativaCampos();
            //verifica se eh gerente ou administrador
            UsuarioProjeto up = control.GetUsuarioProjeto(this.projeto.Id, SessaoSistema.UsuarioId);
            TipoUsuarioController tuc = new TipoUsuarioController();
            if (up == null)
            {
                AtivaDesativaCampos(false);
            }
            else
            {
                AtivaDesativaCampos(tuc.BuscarPorId(up.TipoUsuarioId+"").Administrador);
            }

        }

        //click botao salvar projeto
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProjetoController control = new ProjetoController();

            Object retorno = control.Salvar(lblId.Text.Trim(), txtNome.Text.Trim(), txtDescricao.Text.Trim(),
                dtInicio.Text.Trim(), dtPrevista.Text.Trim(), Validar.GetBytes(txtPlanoProjeto.Rtf), 
                "", SituacaoProjeto.GetEnum(cbSituacao.SelectedValue.ToString()));

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
                dtFim.Text = ((Models.Projeto)retorno).DataConclusao + "";
                Mensagem.Informacao("Salvo com sucesso");
                projeto = (Models.Projeto)retorno;
                AtivaDesativaCampos();
            }
        }

        //click botao novo projeto
        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoProjeto novo = new NovoProjeto();
            Janela.Exibir(novo, this.MdiParent, true);
            this.Close();
            AtivaDesativaCampos();
        }
        
        //click botao incluir equipe
        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDAO uDao = new UsuarioDAO();
            TipoUsuarioDAO tuDao = new TipoUsuarioDAO();
            Usuario u = uDao.selectNome(cbUsuario.SelectedItem.ToString())[0];
            TipoUsuario tu = tuDao.selectNome(cbPapel.SelectedItem.ToString())[0];
            UsuarioProjetoController control = new UsuarioProjetoController();
            control.Salvar(tu.Id, Convert.ToInt32(lblId.Text.Trim()), u.Id);

            AtualizaGridEquipe(control);

        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (gridEquipe.SelectedRows.Count > 0)
            {
                EquipeProjeto ep = equipe[gridEquipe.SelectedRows[0].Index];
                UsuarioController uc = new UsuarioController();
                UsuarioProjetoController upc = new UsuarioProjetoController();
                UsuarioProjeto up = upc.GetUsuarioProjeto(projeto.Id, uc.BuscarPorNome(ep.NomeUsuario)[0].Id);

                Object excluir = upc.ExcluirUsuario(up.Id);

                if (excluir!= null)
                {
                    Mensagem.Informacao("Excluído com sucesso!");
                }
                else
                {
                    Mensagem.Erro("Não foi possível excluir");
                }

                AtualizaGridEquipe(upc);
            }
        }
        private void AtualizaGridEquipe(UsuarioProjetoController control)
        {
            gridEquipe.DataSource = null;
            equipe = control.GetUsuariosDoProjeto(Convert.ToInt32(lblId.Text.Trim()));
            gridEquipe.DataSource = equipe;
            gridEquipe.Columns["NomeUsuario"].HeaderText = "Nome do Membro da Equipe";
            gridEquipe.Columns["Papel"].HeaderText = "Papel No Projeto";
            gridEquipe.Columns["NomeUsuario"].Width = (gridEquipe.Size.Width / 2)-10;
            gridEquipe.Columns["Papel"].Width = (gridEquipe.Size.Width / 2)-10;
        }
        
        //click botao nova fase
        private void btnNovaFase_Click(object sender, EventArgs e)
        {
            FaseProjeto fase = new FaseProjeto(this);
            fase.ExibirNova(this.MdiParent, this.projeto);
        }

        //click botao editar fase
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

        //click botao nova atividade
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

        //click botao editar atividade
        private void button1_Click(object sender, EventArgs e)
        {
            if (gridAtividade.SelectedRows.Count > 0)
            {
                AtividadeController control = new AtividadeController();
                NovaAtividade atv = new NovaAtividade(this, Convert.ToInt32(lblId.Text.Trim()));
                Atividade atv_ =  control.BuscarPorId(atividades[gridAtividade.SelectedRows[0].Index].Id);
                atv.Exibir(this.MdiParent, atv_);
            }
        }

        //Ativa ou desativa os campos em questão a projeto novo
        public void AtivaDesativaCampos()
        {
            if (lblId.Text.Trim() == string.Empty)
            {
                cbPapel.Enabled = false;
                cbUsuario.Enabled = false;
                btnIncluirUsuario.Enabled = false;
                btnExcluirUsuario.Enabled = false;
                ((Control)tabFase).Enabled = false;
            }
            else
            {
                cbPapel.Enabled = true;
                cbUsuario.Enabled = true;
                btnIncluirUsuario.Enabled = true;
                btnExcluirUsuario.Enabled = true;
                ((Control)tabFase).Enabled = true;
            }
        }

        //Ativa ou desativa os campos em questao ao gerente de projetos
        public void AtivaDesativaCampos(bool Gerente)
        {
            if (!Gerente && !SessaoSistema.Administrador)
            {
                ((Control)tabProjeto).Enabled = false;
                ((Control)tabPlano).Enabled = false;
                ((Control)tabFase).Enabled = false;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;
            }
        }

        //Realiza o bloqueio dos campos caso o projeto esteja concluido
        public void BloqueiaProjetoConcluido(bool Concluido)
        {
            if (Concluido)
            {
                btnNovaFase.Enabled = false;
                btnEditarFase.Enabled = false;
                btnNovaAtividade.Enabled = false;
                btnEditarAtividade.Enabled = false;
            }
            else
            {
                btnNovaFase.Enabled = true;
                btnEditarFase.Enabled = true;
                btnNovaAtividade.Enabled = true;
                btnEditarAtividade.Enabled = true;
            }
        }

        //atualiza a grid de fases
        //desativa as colunas que nao sao importante para a grid de Fases 
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

        //atualiza a grid de atividades
        //Desativa as Colunas que nao sao importante para a grid de atividades
        public void gridAtividadesRefresh()
        {
            if (gridFase.SelectedRows.Count > 0)
            {
                AtividadeController aControl = new AtividadeController();
                atividades = aControl.GetAtividadesDaFase(fases[gridFase.SelectedRows[0].Index].Id);
                gridAtividade.DataSource = null;
                gridAtividade.DataSource = atividades;
                gridAtividade.Refresh();
                
            }
        }

        //atualiza grid de atividade ao clicar na fase
        private void gridFase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridAtividadesRefresh();
        }
        //IGNORE THIS METHOD
        private void dtInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e){}

        
    }
}