using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio.Models;
using NovaProjectWeb.Controller.TransientObject;
using System.Collections;
using NovaProjectWeb.View.GridGouper;
using Negocio.Dao;
using Negocio.Models;

namespace NovaProjectWeb.View.pages
{
    public partial class TempoGasto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProjetoDAO pDao = new ProjetoDAO();
            AtividadeDAO aDao = new AtividadeDAO();
            UsuarioProjetoDAO usup = new UsuarioProjetoDAO();

           
        }
    }
}