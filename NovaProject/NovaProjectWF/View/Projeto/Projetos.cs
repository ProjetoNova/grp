using NovaProjectWF.Controllers.ProjetoController;
using NovaProjectWF.Controllers.SessaoController;
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
    public partial class Projetos : Form
    {
        private List<Negocio.Models.Projeto> listaProjeto;

        public Projetos()
        {
            InitializeComponent();
        }

        //Meus Projetos
        //Todos os Projetos
        //Em Aberto
        //Em Execução
        //Encerrados

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ProjetoController control = new ProjetoController();

            if (cbProjetos.SelectedItem == null)
            {

            }
            else if (cbProjetos.SelectedItem.ToString() == "Meus Projetos") 
            {
                listaProjeto = control.ProjetoPorUsuario(SessaoSistema.UsuarioId);
                dataGridView1.DataSource = listaProjeto;
                OcultarColunas();
            }
            else if (cbProjetos.SelectedItem.ToString() == "Todos os Projetos")
            {
                listaProjeto = control.TodosOsDados();
                dataGridView1.DataSource = listaProjeto;
                OcultarColunas();
            }
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NovoProjeto novoProjeto = new NovoProjeto();

            Negocio.Models.Projeto proj = null;

            if (e.RowIndex < 0)
            {
                return;
            }

            proj = listaProjeto[e.RowIndex];

            novoProjeto.Exibir(this.MdiParent, proj);
        }

        private void OcultarColunas()
        {
            this.dataGridView1.Columns["FaseProjeto"].Visible = false;
            this.dataGridView1.Columns["Anexos"].Visible = false;
            this.dataGridView1.Columns["Usuarios"].Visible = false;
            this.dataGridView1.Columns["Descricao"].Visible = false;
            this.dataGridView1.Columns["PlanoProjeto"].Visible = false;
        }
    }
}
