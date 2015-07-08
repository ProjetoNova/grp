using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Controllers.SessaoController;
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

namespace NovaProjectWF.View.Conta
{
    public partial class MinhaConta : Form
    {
        UsuarioController control;

        Usuario user;

        public MinhaConta()
        {
            InitializeComponent();

            control = new UsuarioController();
            
            user =(Usuario) control.BuscarPorId(SessaoSistema.UsuarioId+"");

            txtNome.Text = user.Nome;
            txtEmail.Text = user.Email;
            txtExperiencia.Text = user.ExperienciaSistema;
            txtFormacao.Text = user.FormacaoAcademica;
            txtLink.Text = user.LinkExterno;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            user.Nome = txtNome.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.ExperienciaSistema = txtExperiencia.Text.Trim();
            user.FormacaoAcademica = txtFormacao.Text.Trim();
            user.LinkExterno = txtLink.Text.Trim();

            control.Salvar(user.Id+"",user.Nome, user.FormacaoAcademica, user.ExperienciaSistema
                , user.Email, user.Login, user.Senha, user.Senha, user.LinkExterno, user.Status, user.TipoUsuarioId);
        }
    }
}
