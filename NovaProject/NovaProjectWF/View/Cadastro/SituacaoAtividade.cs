using NovaProjectWF.Controllers;
using NovaProjectWF.Controllers.CadastroController;
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

namespace NovaProjectWF.View.Cadastro
{
    public partial class SituacaoAtividade : Form
    {
        List<Models.SituacaoAtividade> listaControle;

        public SituacaoAtividade()
        {
            InitializeComponent();
            string[] colunas = { "Id", "Nome" };
            comboBox1.DataSource = colunas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SituacaoAtividadeController controller = new SituacaoAtividadeController();

            Object retorno = controller.Salvar(lblId.Text, txtNome.Text.Trim(),
                cbAtivo.Checked, cbConcluida.Checked);

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
                lblId.Text = ((Models.SituacaoAtividade)retorno).Id + "";
                Mensagem.Informacao("Salvo com sucesso");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            txtNome.Text = string.Empty;
            cbAtivo.Checked = true;
            cbConcluida.Checked = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SituacaoAtividadeController control = new SituacaoAtividadeController();
            listaControle = new List<Models.SituacaoAtividade>();

            if (textBox1.Text.Trim() == string.Empty)
            {
                dataGridView1.DataSource = null;
                listaControle = control.TodosOsDados();
                dataGridView1.DataSource = listaControle;
            }
            else if (comboBox1.SelectedValue.ToString() == "Id")
            {
                if (Validar.Numero(textBox1.Text.Trim()))
                {
                    listaControle.Add(
                        control.BuscarPorId(textBox1.Text.Trim()));
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listaControle;
                    dataGridView1.Refresh();
                }
                else
                {
                    Mensagem.Aviso("Nenhum dado encontrado");
                }
            }
            else if (comboBox1.SelectedValue.ToString() == "Nome")
            {
                listaControle =
                        control.BuscarPorNome(textBox1.Text.Trim());
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaControle;
                dataGridView1.Refresh();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Models.SituacaoAtividade situacao = null;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                situacao = listaControle[row.Index];
            }

            if (situacao != null)
            {
                lblId.Text = situacao.Id + "";
                txtNome.Text = situacao.Nome;
                cbConcluida.Checked = situacao.Concluida;
                cbAtivo.Checked = situacao.Status;

                tabControl1.SelectedIndex = 0;
            }
        }
    }
}
