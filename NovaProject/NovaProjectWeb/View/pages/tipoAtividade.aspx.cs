using Negocio.Dao;
using Negocio.Models;
using NovaProjectWeb.Controller.SessaoController;
using NovaProjectWeb.Controller.TransientObject;
using NovaProjectWeb.View.GridGouper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaProjectWeb.View.pages
{
    public partial class TipoAtividade : System.Web.UI.Page
    {

        TipoAtvidadeDAO dao;
        AtividadeDAO aDao;

        protected void Page_Load(object sender, EventArgs e)
        {
            labelNome.Text = SessaoSistema.NomeUsuario;
            dao = new TipoAtvidadeDAO();
            aDao = new AtividadeDAO();

            gridTipoAtv.DataSource = SelectEmAberto();
            gridTipoAtv.DataBind();
            
        }

        public void filtrar(object sender, EventArgs e)
        {

            switch (rdBtnList.SelectedValue)
            {
                case "0":
                    {
                        gridTipoAtv.DataSource = SelectEmAberto();
                        gridTipoAtv.DataBind();
                        break;
                    }
                case "1":
                    {
                        gridTipoAtv.DataSource = SelectConcluida();
                        gridTipoAtv.DataBind();
                        break;
                    }
            }

        }

        public List<RelTipoAtvTo> SelectEmAberto()
        {
            List<Negocio.Models.TipoAtividade> lta = new List<Negocio.Models.TipoAtividade>();
            List<RelTipoAtvTo> lista = new List<RelTipoAtvTo>();

            lta = dao.selectAll();

            foreach(Negocio.Models.TipoAtividade ta in lta) {
                List<Negocio.Models.Atividade> lAtv = aDao.PorTipoEmAberto(ta.Id);

                RelTipoAtvTo to = new RelTipoAtvTo();
                to.Descricao = ta.Nome;
                to.QntdAtv = lAtv.Count;

                double Horas = 0;

                foreach (Atividade a in lAtv)
                {
                    Horas += Convert.ToDouble(a.TempoGasto);
                }

                lista.Add(to);
            }

            return lista;

        }

        public List<RelTipoAtvTo> SelectConcluida()
        {
            List<Negocio.Models.TipoAtividade> lta = new List<Negocio.Models.TipoAtividade>();
            List<RelTipoAtvTo> lista = new List<RelTipoAtvTo>();

            lta = dao.selectAll();

            foreach (Negocio.Models.TipoAtividade ta in lta)
            {
                List<Negocio.Models.Atividade> lAtv = aDao.PorTipoConcluida(ta.Id);

                RelTipoAtvTo to = new RelTipoAtvTo();
                to.Descricao = ta.Nome;
                to.QntdAtv = lAtv.Count;

                lista.Add(to);
            }

            return lista;
        }

        protected void OnSelectedIndexChanging(GridViewSelectEventArgs e)
        {

        }

        protected void gridAtv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void gridAtv_Sorting(object sender, GridViewSortEventArgs e)
        {

        }
     }
}