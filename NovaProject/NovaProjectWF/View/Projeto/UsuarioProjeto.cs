using Negocio.Dao;
using Negocio.Models;
using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Controllers.ProjetoController;
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
    public partial class UsuarioProjeto : Form
    {
        public UsuarioProjeto()
        {
            InitializeComponent();
        }

        Negocio.Models.UsuarioProjeto entidade;

        public void Exibir(Form parent, Negocio.Models.UsuarioProjeto entidade)
        {
            this.entidade = entidade;
            UsuarioController controlUser = new UsuarioController();
            TipoUsuarioController controlTUsuario = new TipoUsuarioController();
            Negocio.Models.Usuario user = controlUser.BuscarPorId(entidade.UsuarioId+"");
            txtNomeUsuario.Text = user.Nome;
            List<String> papeis = controlTUsuario.TodosOsNomes();
            cbPapel.DataSource = papeis;
            cbPapel.SelectedIndex = papeis.IndexOf(controlTUsuario.BuscarPorId(entidade.TipoUsuarioId+"").Nome);
            dtInclusao.Value = Convert.ToDateTime(entidade.InicioProjeto);
            dtSaida.Value = Convert.ToDateTime(entidade.FimProjeto);
            cbAtivo.Checked = entidade.Status;

            ProjetoDAO pDao = new ProjetoDAO();
            Negocio.Models.Projeto proj = (Negocio.Models.Projeto)pDao.select(Convert.ToInt32(entidade.ProjetoId));

            dtInclusao.MinDate = Convert.ToDateTime(proj.DataInicio);
            dtInclusao.MaxDate = Convert.ToDateTime(proj.DataPrevisao);
            dtSaida.MinDate = Convert.ToDateTime(proj.DataInicio);
            dtSaida.MaxDate = Convert.ToDateTime(proj.DataPrevisao);

            rtbObservacoes.Text = entidade.Observacao;

            if (Janela.Fechada(parent, this.GetType()))
            {
                Janela.Exibir(this, parent, false);
            }
            else
            {
                Janela.JanelaAberta(parent, this.GetType()).Close();
                Janela.Exibir(this, parent, false);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        
        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            UsuarioProjetoController control = new UsuarioProjetoController();
            TipoUsuarioDAO tuDao = new TipoUsuarioDAO();
            TipoUsuario tu = tuDao.selectNome(cbPapel.SelectedItem.ToString())[0];
            control.Update(entidade, tu.Id, dtInclusao.Value, dtSaida.Value, cbAtivo.Checked, rtbObservacoes.Text);

            Mensagem.Informacao("Registro Salvo com Sucesso!");
            this.Close();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
}