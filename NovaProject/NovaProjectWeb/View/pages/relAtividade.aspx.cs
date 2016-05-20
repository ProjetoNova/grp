using Negocio.Dao;
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

namespace NovaProjectWeb.View.pages
{
    public partial class RelAtividade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtividadeDAO aDao = new AtividadeDAO();
            SituacaoAtividadeDAO saDao = new SituacaoAtividadeDAO();
            UsuarioDAO usuDao = new UsuarioDAO();
            TipoAtvidadeDAO tDao = new TipoAtvidadeDAO();

            List<Negocio.Models.Atividade> lista = aDao.AtividadesAbertaPorUsuario();

            List<RelAtividadeTo> listaRetorno = new List<RelAtividadeTo>();

            foreach (Atividade atv in lista)
            {
                RelAtividadeTo to = new RelAtividadeTo();
                to.DataInicio = atv.DataInicio;
                to.DataPrevista = atv.DataPrevista;
                to.NomeAtividade = atv.Titulo;

                String situacao = ((SituacaoAtividade)saDao.select(atv.SituacaoAtividadeId)).Nome;
                String usuario = ((Usuario)usuDao.select(atv.UsuarioId)).Nome;
                String tipoAtividade = ((Negocio.Models.TipoAtividade)tDao.select(atv.TipoAtividadeId)).Nome;

                to.SituacaoAtividade = situacao;
                to.NomeUsuario = usuario;
                to.TipoAtividade = tipoAtividade;

                listaRetorno.Add(to);
            }

            //gridAtv.Sort("NomeUsuario", SortDirection.Ascending);
            gridAtv.DataSource = listaRetorno;
            gridAtv.DataBind();
            GridViewGrouper.GroupGridView(gridAtv.Rows, 0, 1);
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