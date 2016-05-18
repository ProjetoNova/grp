using NovaProjectWeb.Controller.ProjetoController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaProjectWeb.View.pages
{
    public partial class relAtividade : System.Web.UI.Page
    {
        List<Negocio.Models.Atividade> listaAtividades;

        relAtividade()
        {

            RelatorioAtividades dao = new RelatorioAtividades();

            listaAtividades = dao.AtividadesPorUsuario();
        }
    }
}