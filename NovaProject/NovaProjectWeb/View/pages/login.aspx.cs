using NovaProjectWF.Controllers.SessaoController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaProjectWeb.View.pages
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void lancaErro(string mensagem)
        {
            //lblMensagem.Text = mensagem;
            //lblMensagem.ForeColor = System.Drawing.Color.Red;
        }

        private void ocultaErro()
        {
            //lblMensagem.Text = "";
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            string nome = txtLogin.Text.Trim();
            string senha = password.Text.Trim();

            if (nome.Equals(string.Empty))
            {
                lancaErro("Login não pode ser vazio!");
            }
            else if (senha.Equals(string.Empty))
            {
                lancaErro("Senha não pode ser vazia!");
            }
            else
            {
                LoginController controll = new LoginController();

                if (controll.Login(nome, senha))
                {
                    lancaErro("Fez Login!");

                    Response.Redirect("index.html");
                }
                else
                {
                    lancaErro("Login ou senha errado!");
                }
            }
        }

    }
}