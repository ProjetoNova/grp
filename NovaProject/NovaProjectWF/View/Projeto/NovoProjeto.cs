using NovaProjectWF.Controllers;
using NovaProjectWF.Controllers.ProjetoController;
using Negocio.Models.Enumerados;
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
using Negocio.Models;
using Negocio.Dao;
using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Controllers.SessaoController;
using Negocio.Models.NaoPersistido;

namespace NovaProjectWF.View.Projeto
{
    public partial class NovoProjeto : Form
    {
        Negocio.Models.Projeto projeto;
        List<Negocio.Models.FaseProjeto> fases;
        List<EquipeProjeto> equipe;
        List<AtividadeProjeto> atividades;
        List<ArtefatosProjeto> artefatos;
        PropriedadeArtefato propArte;
        Form parent;

        public NovoProjeto()
        {
            InitializeComponent();
            cbSituacao.DataSource = SituacaoProjeto.GetList();
            UsuarioController controlUser = new UsuarioController();
            TipoUsuarioController controlTUsuario = new TipoUsuarioController();
            cbUsuario.DataSource = controlUser.TodosOsNomes();
            cbPapel.DataSource = controlTUsuario.TodosOsNomes();
            dtInicio.Value = DateTime.Today;
            dtPrevista.Value = DateTime.Today;

            AtivaDesativaCampos();
        }

        //Metodo para Exibir um Projeto Ja existente
        public void Exibir(Form parent, Object projeto)
        {
            this.parent = parent;
            ProjetoController pcontrol = new ProjetoController();
            //atribui os valores
            this.projeto = (Negocio.Models.Projeto)projeto;
            string id = this.projeto.Id.ToString();
            this.projeto = pcontrol.BuscarPorId(id);

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
            
            atualizaGridArtefato();
            //verifica se eh gerente ou administrador
            Negocio.Models.UsuarioProjeto up = control.GetUsuarioProjeto(this.projeto.Id, SessaoSistema.UsuarioId);
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

            string conteudo = "";

            if (txtPlanoProjeto.Text.Trim() != string.Empty)
                conteudo = txtPlanoProjeto.Rtf;

            Object retorno = control.Salvar(lblId.Text.Trim(), txtNome.Text.Trim(), txtDescricao.Text.Trim(),
                dtInicio.Text.Trim(), dtPrevista.Text.Trim(), Validar.GetBytes(conteudo), 
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
                lblId.Text = ((Negocio.Models.Projeto)retorno).Id + "";
                dtFim.Text = ((Negocio.Models.Projeto)retorno).DataConclusao + "";
                Mensagem.Informacao("Salvo com sucesso");
                projeto = (Negocio.Models.Projeto)retorno;
                UsuarioProjetoController upcontrol = new UsuarioProjetoController();
                UsuarioController ucontrol = new UsuarioController();
                TipoUsuarioController tucontrol = new TipoUsuarioController();

                upcontrol.Salvar(tucontrol.TodosOsDados().First().Id, projeto.Id, 
                    ucontrol.TodosOsDados().First().Id);
                AtualizaGridEquipe(upcontrol);
                AtivaDesativaCampos();
            }
        }

        //click botao novo projeto
        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoProjeto novo = new NovoProjeto();
            this.Close();
            //Janela.Exibir(novo, MdiParent, true);
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
                Negocio.Models.UsuarioProjeto up = upc.GetUsuarioProjeto(projeto.Id, uc.BuscarPorNome(ep.NomeUsuario)[0].Id);

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
            if (!SessaoSistema.NovoFaseProjeto && !SessaoSistema.Administrador)
            {
                Mensagem.Aviso("Voce nao tem acesso a essa tela!");
                return;
            }

            FaseProjeto fase = new FaseProjeto(this);
            fase.ExibirNova(this.MdiParent, this.projeto);
        }

        //click botao editar fase
        private void btnEditarFase_Click(object sender, EventArgs e)
        {
            if (gridFase.SelectedRows.Count > 0)
            {
                FaseProjeto fase = new FaseProjeto(this);
                Negocio.Models.FaseProjeto fase_ = null;
                fase_ =  fases[gridFase.SelectedRows[0].Index];
                fase_.Projeto = projeto;
                fase.Exibir(this.MdiParent, fase_);
            }
        }

        //click botao nova atividade
        private void btnAtividade_Click(object sender, EventArgs e)
        {
            if (!SessaoSistema.NovoAtividade && !SessaoSistema.Administrador)
            {
                Mensagem.Aviso("Voce nao tem acesso a essa tela!");
                return;
            }

            if (gridFase.SelectedRows.Count > 0)
            {
                NovaAtividade atv = new NovaAtividade(this, Convert.ToInt32(lblId.Text.Trim()));
                Negocio.Models.FaseProjeto fase = fases[gridFase.SelectedRows[0].Index];
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
                Atividade atv_ = null;
                atv_ =  control.BuscarPorId(atividades[gridAtividade.SelectedRows[0].Index].Id);
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

        public void atualizaGridArtefato()
        {
            AnexoProjetoController aC = new AnexoProjetoController();

            gridArtefato.DataSource = null;
            artefatos = aC.getArtefatoPorProjeto(projeto.Id);
            gridArtefato.DataSource = artefatos;
            gridArtefato.Columns["IdAnexo"].Visible = false;
            gridArtefato.Columns["TamanhoArquivo"].Visible = false;
            gridArtefato.Columns["DataArquivo"].Visible = false;
            gridArtefato.Columns["Responsavel"].Visible = false;
            gridArtefato.Columns["Projeto"].Visible = false;
            gridArtefato.Columns["Observacoes"].Visible = false;
            gridArtefato.Columns["NomeArquivo"].Width = gridArtefato.Width-45;
            gridArtefato.Columns["NomeArquivo"].Resizable = DataGridViewTriState.False;
            gridArtefato.Columns["NomeArquivo"].Name = "Artefatos";
            gridArtefato.Refresh();
        }

        //atualiza grid de atividade ao clicar na fase
        private void gridFase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridAtividadesRefresh();
        }
        //IGNORE THIS METHOD
        private void dtInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e){}

        private void btnPropriedades_Click(object sender, EventArgs e)
        {
            if (gridArtefato.SelectedRows.Count > 0)
            {
                PropriedadeArtefato prop = new PropriedadeArtefato();

                ArtefatosProjeto artefato = artefatos[gridArtefato.SelectedRows[0].Index];

                prop.Exibir(this.MdiParent, artefato);
            }
        }

        private void btnCarregarArtefato_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);

                    if (sr.BaseStream.Length > 10485760)
                    {
                        MessageBox.Show("Tamanho Máximo do Arquivo é de 10MB");
                    }
                    else
                    {
                        AnexoProjetoController control = new AnexoProjetoController();

                        control.Salvar("0", projeto.Id, SessaoSistema.UsuarioId, sr, DateTime.Now, openFileDialog1.SafeFileName, "");

                        MessageBox.Show("Arquivo Carregado com Sucesso!");

                        atualizaGridArtefato();
                    }

                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao carregar Arquivo");
                    return;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridArtefato.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Deseja Excluir o Artefato?", "Excluir Artefato", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    ArtefatosProjeto artefato = artefatos[gridArtefato.SelectedRows[0].Index];

                    AnexoProjetoDAO dao = new AnexoProjetoDAO();

                    dao.delete((AnexoProjeto)dao.select(artefato.IdAnexo));

                    atualizaGridArtefato();
                }
            }
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            UsuarioController controlUser = new UsuarioController();
            TipoUsuarioController controlTUsuario = new TipoUsuarioController();
            cbUsuario.DataSource = controlUser.TodosOsNomes();
            cbPapel.DataSource = controlTUsuario.TodosOsNomes();

            Mensagem.Informacao("Projeto Atualizado!");
        }

        private void btnEditarUP_Click(object sender, EventArgs e)
        {
            if (gridEquipe.SelectedRows.Count > 0)
            {
                EquipeProjeto ep = equipe[gridEquipe.SelectedRows[0].Index];
                UsuarioController uc = new UsuarioController();
                UsuarioProjetoController upc = new UsuarioProjetoController();
                Negocio.Models.UsuarioProjeto up = upc.GetUsuarioProjeto(projeto.Id, uc.BuscarPorNome(ep.NomeUsuario)[0].Id);

                View.Projeto.UsuarioProjeto upView = new View.Projeto.UsuarioProjeto();
                upView.Exibir(parent, up);

                AtualizaGridEquipe(upc);
            }
        }
    }
}