using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NovaProjectWeb.Controller.SessaoController;

namespace NovaProjectWeb.View.pages
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelNome.Text = SessaoSistema.NomeUsuario;
        }
    }
}