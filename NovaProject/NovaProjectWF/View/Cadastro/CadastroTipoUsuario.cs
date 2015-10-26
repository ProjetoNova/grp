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
        List<TipoUsuario> listaControle;

        public CadastroTipoUsuario()
        {
            InitializeComponent();
            string[] colunas = {"Id", "Nome"};
            comboBox1.DataSource = colunas;
            ckdPermissoes.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e){}
        private void button3_Click(object sender, EventArgs e){}
        private void button4_Click(object sender, EventArgs e){}

        //botao pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            TipoUsuarioController control = new TipoUsuarioController();
            listaControle = new List<TipoUsuario>();

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
                listaControle=
                        control.BuscarPorNome(textBox1.Text.Trim());
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaControle;
                dataGridView1.Refresh();
            }
        }

        //botao salvar
        private void button1_Click_1(object sender, EventArgs e)
        {
            TipoUsuarioController controller = new TipoUsuarioController();

            List<int> itens = new List<int>();

            Object retorno = controller.Salvar(lblId.Text, txtNome.Text.Trim(), 
                checkBox1.Checked, cbAdministrador.Checked);

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


            if (!lblId.Text.Equals("0") || !lblId.Text.Equals(""))
            {
                if (!cbAdministrador.Checked) 
                {
                    foreach (int itemChecked in ckdPermissoes.CheckedIndices)
                    {
                        controller.IncluirPermissao(itemChecked, Convert.ToInt32(lblId.Text));
                    }
                }
            }
        }

        //botao novo
        private void button3_Click_1(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            txtNome.Text = string.Empty;
            checkBox1.Checked = true;
            cbAdministrador.Checked = false;
            ckdPermissoes.Enabled = true;
        }

        //botao editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoUsuario tipoUsuario = null;
            TipoUsuarioController control = new TipoUsuarioController();

            foreach(DataGridViewRow row in dataGridView1.SelectedRows) {
                tipoUsuario = listaControle[row.Index];
            }

            if(tipoUsuario!=null) {
                lblId.Text = tipoUsuario.Id+"";
                txtNome.Text = tipoUsuario.Nome;
                cbAdministrador.Checked = tipoUsuario.Administrador;
                checkBox1.Checked = tipoUsuario.Status;
                ckdPermissoes.Enabled = !cbAdministrador.Checked;
                tabControl1.SelectedIndex = 0;

                for (int a = 0; a < ckdPermissoes.Items.Count; a++)
                    ckdPermissoes.SetItemChecked(a, false);

                List<PermissaoTipoUsuario> permissoes = control.BuscarPorTipoDeUsuario(tipoUsuario.Id);
                foreach(PermissaoTipoUsuario p in permissoes) {
                    ckdPermissoes.SetItemChecked(p.PermissaoIndice, true);
                }
                
            }
        }

        private void cbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            ckdPermissoes.Enabled = !cbAdministrador.Checked;
        }
    }
}