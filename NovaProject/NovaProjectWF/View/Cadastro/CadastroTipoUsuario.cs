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

namespace NovaProjectWF.View.Cadastro
{
    public partial class CadastroTipoUsuario : Form
    {
        PesquisaTipoUsuario pesquisa;

        public CadastroTipoUsuario()
        {
            InitializeComponent();
        }

        //botao salvar
        private void button1_Click(object sender, EventArgs e)
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
        private void button3_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Janela.Fechada(this.MdiParent, typeof(PesquisaTipoUsuario)))
                pesquisa = new PesquisaTipoUsuario();

            Janela.Exibir(pesquisa, this.MdiParent);
        }
    }
}
