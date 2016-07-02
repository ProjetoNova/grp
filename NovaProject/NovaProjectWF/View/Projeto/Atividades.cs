using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Controllers.ProjetoController;
using NovaProjectWF.Controllers.SessaoController;
using Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaProjectWF.View.Projeto
{
    public partial class Atividades : Form
    {
        List<string> situacoes;

        List<Atividade> atividades;

        SituacaoAtividadeController control;

        AtividadeController aControl;

        public Atividades()
        {
            InitializeComponent();

            control = new SituacaoAtividadeController();
            aControl = new AtividadeController();

            comboBox1.DataSource = null;
            situacoes = control.TodosOsNomes();
            comboBox1.DataSource = situacoes;
        }

        private void LimparGrid()
        {
            this.gridAtividade.Columns["FaseProjetoId"].Visible = false;
            this.gridAtividade.Columns["UsuarioId"].Visible = false;
            this.gridAtividade.Columns["TipoAtividadeId"].Visible = false;
            this.gridAtividade.Columns["FaseProjeto"].Visible = false;
            this.gridAtividade.Columns["Colaborador"].Visible = false;
            this.gridAtividade.Columns["TipoAtividade"].Visible = false;
            this.gridAtividade.Columns["Descricao"].Visible = false;
            this.gridAtividade.Columns["TempoEstimado"].Visible = false;
            this.gridAtividade.Columns["TempoGasto"].Visible = false;
            this.gridAtividade.Columns["SituacaoAtividadeId"].Visible = false;
            this.gridAtividade.Columns["SituacaoAtividade"].Visible = false;
        }
        
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem!=null) {

                SituacaoAtividade s =  control.BuscarPorNome(comboBox1.SelectedItem.ToString())[0];

                AtividadeController atv = new AtividadeController();

                if (rbMinhas.Checked)
                {
                    atividades = new List<Atividade>();

                    foreach (Atividade item in atv.GetAtividadePorSituacao(s))
                    {
                        if (item.UsuarioId.Equals(SessaoSistema.UsuarioId))
                        {
                            atividades.Add(item);
                        }
                    }

                    gridAtividade.DataSource = null;
                    gridAtividade.DataSource = atividades;
                }
                else
                {
                    gridAtividade.DataSource = null;
                    atividades = atv.GetAtividadePorSituacao(s);
                    gridAtividade.DataSource = atividades;

                }

                LimparGrid();   
          }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex("[0-9]+");

            if (txtPesquisa.Text.Trim() == string.Empty)
            {
                gridAtividade.DataSource = null;
            }
            else if (txtPesquisa.Text.StartsWith("#") &&
                regex.IsMatch(txtPesquisa.Text.Replace("#", "")))
            {
               atividades = new List<Atividade>();
               atividades.Add(aControl.BuscarPorId(txtPesquisa.Text.Replace("#", "")));

               gridAtividade.DataSource = null;
               gridAtividade.DataSource = atividades;

               LimparGrid();
            }

            else
            {
                atividades = new List<Atividade>();

                atividades = aControl.BuscarPorNomeOuDescricao(txtPesquisa.Text.Trim());

                gridAtividade.DataSource = null;
                gridAtividade.DataSource = atividades;

                LimparGrid();
            }
        }

        private void gridAtividade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (gridAtividade.SelectedRows.Count > 0)
            {
                Atividade atv_ = atividades[gridAtividade.SelectedRows[0].Index];

                FaseProjetoController fControl = new FaseProjetoController();

                Negocio.Models.FaseProjeto fp = fControl.BuscarPorId(atv_.FaseProjetoId+"");

                NovaAtividade atv = new NovaAtividade(null, fp.ProjetoId);

                atv.Exibir(this.MdiParent, atv_);
            }
        }
    }
}
