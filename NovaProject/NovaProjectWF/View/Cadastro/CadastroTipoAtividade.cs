using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaProjectWF.Models.Interfaces;
using NovaProjectWF.Models;
using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Controllers;

namespace NovaProjectWF.View.Utilitarios
{
    public partial class CadastroTipoAtividade : Form
    {
        List<TipoAtividade> listaControle;

        public CadastroTipoAtividade()
        {
            InitializeComponent();
            string[] colunas = { "Id", "Nome" };
            cbPesquisa.DataSource = colunas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TipoAtividadeController controller = new TipoAtividadeController();

            Object retorno = controller.Salvar(lblId.Text, txtNome.Text.Trim(),
                cbAtivo.Checked);

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
                lblId.Text = ((TipoAtividade)retorno).Id + "";
                Mensagem.Informacao("Salvo com sucesso");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            txtNome.Text = string.Empty;
            cbAtivo.Checked = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            TipoAtividadeController control = new TipoAtividadeController();
            listaControle = new List<TipoAtividade>();

            if (txtPesquisa.Text.Trim() == string.Empty)
            {
                gridTipoAtividade.DataSource = null;
                listaControle = control.TodosOsDados();
                gridTipoAtividade.DataSource = listaControle;
            }
            else if (cbPesquisa.SelectedValue.ToString() == "Id")
            {
                if (Validar.Numero(txtPesquisa.Text.Trim()))
                {
                    listaControle.Add(
                        control.BuscarPorId(txtPesquisa.Text.Trim()));
                    gridTipoAtividade.DataSource = null;
                    gridTipoAtividade.DataSource = listaControle;
                    gridTipoAtividade.Refresh();
                }
                else
                {
                    Mensagem.Aviso("Nenhum dado encontrado");
                }
            }
            else if (cbPesquisa.SelectedValue.ToString() == "Nome")
            {
                listaControle =
                        control.BuscarPorNome(txtPesquisa.Text.Trim());
                gridTipoAtividade.DataSource = null;
                gridTipoAtividade.DataSource = listaControle;
                gridTipoAtividade.Refresh();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoAtividade tipoAtividade = null;

            foreach (DataGridViewRow row in gridTipoAtividade.SelectedRows)
            {
                tipoAtividade = listaControle[row.Index];
            }

            if (tipoAtividade != null)
            {
                lblId.Text = tipoAtividade.Id + "";
                txtNome.Text = tipoAtividade.Nome;
                cbAtivo.Checked = tipoAtividade.Status;

                tabControl1.SelectedIndex = 0;
            }
        }
    }
}
