using NovaProjectWF.Controllers;
using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Controllers.ProjetoController;
using NovaProjectWF.Controllers.SessaoController;
using NovaProjectWF.Models;
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

namespace NovaProjectWF.View.Projeto
{
    public partial class NovaAtividade : Form
    {
        Atividade atividade;
        NovoProjeto proj;
        AtividadeController control;
        TipoAtividadeController tControl;
        SituacaoAtividadeController sControl;
        UsuarioProjetoController uControl;
        UsuarioController userControl;
        FaseProjetoController fControl;
        ProjetoController pControl;

        List<string> tipos;
        List<string> situacoes;
        List<string> usuarios;

        //inicia uma atividade ja existente
        public NovaAtividade(Object janelaProjeto, int ProjetoId)
        {
            InitializeComponent();
            if(janelaProjeto != null)
                proj = (NovoProjeto)janelaProjeto;
            tControl = new TipoAtividadeController();
            sControl = new SituacaoAtividadeController();
            uControl = new UsuarioProjetoController();
            userControl = new UsuarioController();
            fControl = new FaseProjetoController();
            pControl = new ProjetoController();
            control = new AtividadeController();

            cbTipoAtividade.DataSource = null;
            tipos = tControl.TodosOsNomes();
            cbTipoAtividade.DataSource = tipos;

            cbSituacao.DataSource = null;
            situacoes = sControl.TodosOsNomes();
            cbSituacao.DataSource = situacoes;

            cbAtribuidoPara.DataSource = null;
            usuarios = uControl.GetNomesDoProjeto(ProjetoId);
            cbAtribuidoPara.DataSource = usuarios;

            cbPrioridade.DataSource = null;
            cbPrioridade.DataSource = Prioridade.GetList();
        }

        protected override void OnClosed(EventArgs e)
        {
            AtualizaProjeto();
            base.OnClosed(e);
        }

        private void AtualizaProjeto()
        {
            if(proj != null)
                proj.gridAtividadesRefresh();
        }

        public void Exibir(Form parent, Object Atividade) {

            this.atividade = (Models.Atividade)Atividade;

            this.atividade.TipoAtividade = tControl.BuscarPorId(this.atividade.TipoAtividadeId+"");
            this.atividade.SituacaoAtividade = sControl.BuscarPorId(this.atividade.SituacaoAtividadeId+"");
            this.atividade.Colaborador = userControl.BuscarPorId(this.atividade.UsuarioId + "");
            this.atividade.FaseProjeto = fControl.BuscarPorId(this.atividade.FaseProjetoId + "");
            this.atividade.FaseProjeto.Projeto = pControl.BuscarPorId(this.atividade.FaseProjeto.ProjetoId + "");

            this.label1.Text = this.label1.Text+this.atividade.Id;
            this.txtProjeto.Text = this.atividade.FaseProjeto.Projeto.Titulo;
            this.txtFase.Text = this.atividade.FaseProjeto.Descricao;
            this.txtNome.Text = this.atividade.Titulo;
            this.txtDescricao.Text = this.atividade.Descricao;
            this.dtInicio.Value = this.atividade.DataInicio;
            this.dtPrevista.Value = this.atividade.DataPrevista;
            if (this.atividade.DataFim != null)
            {
                this.dtFim.Text = this.atividade.DataFim.ToString();
            }
            this.cbPrioridade.SelectedIndex = Prioridade.GetIndex(this.atividade.Prioridade);
            this.cbTipoAtividade.SelectedIndex = tipos.IndexOf(this.atividade.TipoAtividade.Nome);
            this.cbSituacao.SelectedIndex = situacoes.IndexOf(this.atividade.SituacaoAtividade.Nome);
            this.cbAtribuidoPara.SelectedIndex = usuarios.IndexOf(this.atividade.Colaborador.Nome);

            if (Janela.Fechada(parent, this.GetType()))
            {
                Janela.Exibir(this, parent, false);
            }
            else
            {
                Janela.JanelaAberta(parent, this.GetType()).Close();
                Janela.Exibir(this, parent, false);
            }

            UsuarioProjetoController upc = new UsuarioProjetoController();
            TipoUsuarioController tuc = new TipoUsuarioController();
            UsuarioProjeto up = upc.GetUsuarioProjeto(this.atividade.FaseProjeto.ProjetoId,
                SessaoSistema.UsuarioId);
            if(up == null) {
                AtivaDesativaCampos(false);
            } else{
                AtivaDesativaCampos(tuc.BuscarPorId(up.TipoUsuarioId.ToString()).Administrador);
            }
        }

        public void ExibirNova(Form parent, Object FaseProjeto)
        {
            this.atividade = new Atividade();
            this.atividade.FaseProjeto = (Models.FaseProjeto)FaseProjeto;
            this.atividade.FaseProjetoId = this.atividade.FaseProjeto.Id;

            this.dtInicio.MinDate = this.atividade.FaseProjeto.DataInicio;
            this.dtInicio.MaxDate = this.atividade.FaseProjeto.DataFim;
            this.dtPrevista.MinDate = this.atividade.FaseProjeto.DataInicio;
            this.dtPrevista.MaxDate = this.atividade.FaseProjeto.DataFim;

            this.txtProjeto.Text = this.atividade.FaseProjeto.Projeto.Titulo;
            this.txtFase.Text = this.atividade.FaseProjeto.Descricao;

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
            Atividade atividade = new Atividade();
            if (cbPrioridade.SelectedItem != null)
            {
                atividade.Prioridade = Prioridade.GetEnum(cbPrioridade.SelectedItem.ToString());
            }
            if (cbSituacao.SelectedItem != null)
            {
                atividade.SituacaoAtividade = sControl.BuscarPorNome(cbSituacao.SelectedItem.ToString())[0];
            }
            if (txtEstimado.Text.Trim().Replace(":", "") != string.Empty)
            {
                atividade.TempoEstimado = Validar.HoraToDouble(txtEstimado.Text.Trim());
            }
            //atividade.TempoGasto = 1;
            if (cbTipoAtividade.SelectedItem != null)
            {
                atividade.TipoAtividade = tControl.BuscarPorNome(cbTipoAtividade.SelectedItem.ToString())[0];
            }
            atividade.Titulo = txtNome.Text.Trim();
            if (cbAtribuidoPara.SelectedItem != null)
            {
                atividade.Colaborador = userControl.BuscarPorNome(cbAtribuidoPara.SelectedItem.ToString())[0];
            }
            //atividade.DataFim = Convert.ToDateTime(dtFim.Text.Trim());
            atividade.DataInicio = Convert.ToDateTime(dtInicio.Value);
            atividade.DataPrevista = Convert.ToDateTime(dtPrevista.Value);
            atividade.Descricao = txtDescricao.Text;
            atividade.FaseProjeto = this.atividade.FaseProjeto;//fControl.BuscarPorNome(this.atividade. txtFase.Text.Trim())[0];

            Object retorno = control.Salvar(label1.Text.Replace("#","").Trim(), atividade.Prioridade, atividade.SituacaoAtividade, atividade.TempoEstimado,
                atividade.TempoGasto, atividade.TipoAtividade, atividade.Titulo, atividade.Colaborador, atividade.DataFim,
                atividade.DataInicio, atividade.DataPrevista, atividade.Descricao, atividade.FaseProjeto);

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
                label1.Text = label1.Text+((Models.Atividade)retorno).Id;
                if (((Atividade)retorno).DataFim != null)
                {
                    dtFim.Text = ((Atividade)retorno).DataFim.Value.ToString();
                }
                Mensagem.Informacao("Salvo com sucesso");
            }

        }

        //Ativa ou desativa os campos em questao ao gerente de projetos
        public void AtivaDesativaCampos(bool Gerente)
        {
            if (!Gerente && !SessaoSistema.Administrador)
            {
                txtNome.Enabled = false;
                txtDescricao.ReadOnly = true;
                cbTipoAtividade.Enabled = false;
                cbPrioridade.Enabled = false;
                dtInicio.Enabled = false;
                dtPrevista.Enabled = false;
                txtEstimado.Enabled = false;
            }
        }

        private void btnEscolherArquivo_Click(object sender, EventArgs e){}
    }
}
