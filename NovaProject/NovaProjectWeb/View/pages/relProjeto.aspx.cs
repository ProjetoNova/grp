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
using NovaProjectWeb.Controller.SessaoController;



namespace NovaProjectWeb.View.pages
{
    public partial class RelProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            labelNome.Text = SessaoSistema.NomeUsuario;
            ProjetoDAO pDao = new ProjetoDAO();
            UsuarioDAO usuDao = new UsuarioDAO();
            UsuarioProjetoDAO usupDAO = new UsuarioProjetoDAO();
            //SituacaoAtividadeDAO saDao = new SituacaoAtividadeDAO();
            // TipoAtvidadeDAO tDao = new TipoAtvidadeDAO();
            FaseProjetoDAO fDao = new FaseProjetoDAO();
            AtividadeDAO aDao = new AtividadeDAO();

            List<Negocio.Models.Projeto> lista = pDao.ProjetosRelatorio();

            List<RelProjetoTo> listaRetorno = new List<RelProjetoTo>();

            foreach (Projeto prj in lista)
            {
                RelProjetoTo to = new RelProjetoTo();
                //to.NomeUsuario = Convert.ToString(prj.Usuarios); //tenho que mudar isso aki
                to.DataInicio = Convert.ToDateTime(prj.DataInicio);
                to.DataPrevista = Convert.ToDateTime(prj.DataPrevisao);
                to.NomeProjeto = prj.Titulo;

                List<FaseProjeto> fpl = fDao.GetFasesDoProjeto(prj.Id);
                
                int qntdAtvPrj = 0;
                foreach(FaseProjeto fp in fpl) {
                    qntdAtvPrj += aDao.GetAtividadesDaFase(fp.Id).Count;
                }

                to.TempoGasto = qntdAtvPrj + " atividades" ;
                //to.DatConclusao = Convert.ToDateTime(prj.DataConclusao);

                listaRetorno.Add(to);   
            }

            gridPrj.DataSource = listaRetorno;
            gridPrj.DataBind();
            
            if (listaRetorno.Count>0)
             GridViewGrouper.GroupGridView(gridPrj.Rows, 0, 1);

            
        }

        protected void OnSelectedIndexChanging(GridViewSelectEventArgs e)
        {

        }

        protected void gridPrj_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void gridPrj_Sorting(object sender, GridViewSortEventArgs e)
        {

        }
    }
}