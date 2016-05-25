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
    public partial class RelProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProjetoDAO pDao = new ProjetoDAO();
            UsuarioDAO usuDao = new UsuarioDAO();
            UsuarioProjetoDAO usupDAO = new UsuarioProjetoDAO();
            //SituacaoAtividadeDAO saDao = new SituacaoAtividadeDAO();
            // TipoAtvidadeDAO tDao = new TipoAtvidadeDAO();

            List<Negocio.Models.Projeto> lista = pDao.ProjetosRelatorio();

            List<RelProjetoTo> listaRetorno = new List<RelProjetoTo>();

            foreach (Projeto prj in lista)
            {
                RelProjetoTo to = new RelProjetoTo();
                to.NomeUsuario = Convert.ToString(prj.Usuarios); //tenho que mudar isso aki
                to.DataInicio = prj.DataInicio;
                to.DataPrevista = prj.DataPrevisao;
                to.NomeProjeto = prj.Titulo;
                to.DatConclusao = prj.DataConclusao;

                listaRetorno.Add(to);   
            }

            gridPrj.DataSource = listaRetorno;
            gridPrj.DataBind();
            GridViewGrouper.GroupGridView(gridPrj.Rows, 0, 1);

            
            }
    }
}