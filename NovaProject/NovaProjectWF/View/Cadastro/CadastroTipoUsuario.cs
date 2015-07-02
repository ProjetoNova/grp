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
using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Models;
using System.Threading;
using NovaProjectWF.Controllers;

namespace NovaProjectWF.View.Utilitarios
{
    public partial class CadastroTipoUsuario : Form
    {
        public CadastroTipoUsuario()
        {
            InitializeComponent();
            string[] colunas = {"Id", "Nome"};
            comboBox1.DataSource = colunas;
        }

        private void button1_Click(object sender, EventArgs e){}
        private void button3_Click(object sender, EventArgs e){}
        private void button4_Click(object sender, EventArgs e){}

        //botao pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            TipoUsuarioController control = new TipoUsuarioController();
            List<TipoUsuario> listaControle = new List<TipoUsuario>();

            if (textBox1.Text.Trim() == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = control.TodosOsDados();
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
                listaControle.Add(
                        control.BuscarPorNome(textBox1.Text.Trim()));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaControle;
                dataGridView1.Refresh();
            }
        }

        //botao salvar
        private void button1_Click_1(object sender, EventArgs e)
        {
            TipoUsuarioController controller = new TipoUsuarioController();

            Object retorno = controller.Salvar(lblId.Text, txtNome.Text.Trim(), txtDescricao.Text.Trim());

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
                lblId.Text = ((TipoUsuario)retorno).Id + "";
                Mensagem.Informacao("Salvo com sucesso");
            }
        }

        //botao novo
        private void button3_Click_1(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }
    }
}
