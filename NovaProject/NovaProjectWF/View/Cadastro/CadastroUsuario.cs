using NovaProjectWF.Controllers;
using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaProjectWF.View.Utilitarios
{
    public partial class CadastroUsuario : Form
    {
        List<Usuario> listaControle;
        List<string> lista;
        public CadastroUsuario()
        {
            InitializeComponent();
            TipoUsuarioController control = new TipoUsuarioController();

            lista = new List<string>();

            foreach(TipoUsuario t in control.TodosOsDados()) {
                if(t.Status)
                    lista.Add(t.Nome);
            }

            cbTipoUsuario.DataSource = lista;

            string[] colunas = { "Id", "Nome" };
            cbPesquisa.DataSource = colunas;
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioController control = new UsuarioController();
            TipoUsuarioController controlTipo = new TipoUsuarioController();

            TipoUsuario tipoUsuario = controlTipo.BuscarPorNome(
                                            cbTipoUsuario.SelectedValue.ToString())[0];

            Object retorno = control.Salvar(lblId.Text, txtNome.Text.Trim(), txtFormacao.Text.Trim(),
                txtExperiencia.Text.Trim(), txtEmail.Text.Trim(), txtLogin.Text.Trim(),
                txtSenha.Text.Trim(), txtConfSenha.Text.Trim(), txtLink.Text.Trim(), cbAtivo.Checked, tipoUsuario.Id,
                false);

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
                lblId.Text = ((Usuario)retorno).Id + "";
                Mensagem.Informacao("Salvo com sucesso");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblId.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtConfSenha.Text = "";
            txtExperiencia.Text = "";
            txtFormacao.Text = "";
            txtLink.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            cbAtivo.Checked = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            UsuarioController control = new UsuarioController();
            listaControle = new List<Usuario>();

            if (textBox1.Text.Trim() == string.Empty)
            {
                gridUsuario.DataSource = null;
                listaControle = control.TodosOsDados();
                gridUsuario.DataSource = listaControle;
            }
            else if (cbPesquisa.SelectedValue.ToString() == "Id")
            {
                if (Validar.Numero(textBox1.Text.Trim()))
                {
                    listaControle.Add(
                        control.BuscarPorId(textBox1.Text.Trim()));
                    gridUsuario.DataSource = null;
                    gridUsuario.DataSource = listaControle;
                    gridUsuario.Refresh();
                }
                else
                {
                    Mensagem.Aviso("Nenhum dado encontrado");
                }
            }
            else if (cbPesquisa.SelectedValue.ToString() == "Nome")
            {
                listaControle =
                        control.BuscarPorNome(textBox1.Text.Trim());
                gridUsuario.DataSource = null;
                gridUsuario.DataSource = listaControle;
                gridUsuario.Refresh();
            }

            this.gridUsuario.Columns["TipoUsuarioId"].Visible = false;
            this.gridUsuario.Columns["Projetos"].Visible = false;
            this.gridUsuario.Columns["TipoUsuarioSistema"].Visible = false;
            this.gridUsuario.Columns["FormacaoAcademica"].Visible = false;
            this.gridUsuario.Columns["ExperienciaSistema"].Visible = false;
            this.gridUsuario.Columns["Senha"].Visible = false;
            this.gridUsuario.Columns["LinkExterno"].Visible = false;
            this.gridUsuario.Columns["Master"].Visible = false;

            this.gridUsuario.Columns["Id"].Width = 20;
        
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;

            foreach (DataGridViewRow row in gridUsuario.SelectedRows)
            {
                usuario = listaControle[row.Index];
            }

            if (usuario != null)
            {
                lblId.Text = usuario.Id + "";
                txtNome.Text = usuario.Nome;
                cbAtivo.Checked = usuario.Status;
                txtEmail.Text = usuario.Email;
                txtLogin.Text = usuario.Login;
                txtSenha.Text = usuario.Senha;
                txtConfSenha.Text = usuario.Senha;
                txtExperiencia.Text = usuario.ExperienciaSistema;
                txtFormacao.Text = usuario.FormacaoAcademica;
                txtLink.Text = usuario.LinkExterno;

                TipoUsuarioController controlTipo = new TipoUsuarioController();

                cbTipoUsuario.SelectedIndex = 
                    lista.IndexOf(controlTipo.BuscarPorId(usuario.TipoUsuarioId + "").Nome);

                tabControl1.SelectedIndex = 0;
            }
        }
    }
}
