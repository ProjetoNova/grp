using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NovaProjectWeb.Controller.SessaoController;
using Negocio.Dao;

namespace NovaProjectWeb.View.pages
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelNome.Text = SessaoSistema.NomeUsuario;
            
            ProjetoDAO dao = new ProjetoDAO();
            projExec.Text = dao.emAberto().Count.ToString();
            
            AtividadeDAO aDao = new AtividadeDAO();
            atvAberto.Text = aDao.AtividadesAbertaPorUsuario().Count.ToString();
            atvAndamento.Text = aDao.AtividadesExecucao().Count.ToString();
            atvAtraso.Text = aDao.AtividadesAtraso().Count.ToString();
        }
    }
}