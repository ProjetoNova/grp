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
using NovaProjectWeb.Controller.SessaoController;

namespace NovaProjectWeb.View.pages
{
    public partial class RelAtividade : System.Web.UI.Page
    {
        List<Negocio.Models.Atividade> lista;

        protected void Page_Load(object sender, EventArgs e)
        {

            labelNome.Text = SessaoSistema.NomeUsuario;
            
            SituacaoAtividadeDAO saDao = new SituacaoAtividadeDAO();
            UsuarioDAO usuDao = new UsuarioDAO();
            TipoAtvidadeDAO tDao = new TipoAtvidadeDAO();
            ProjetoDAO pDao = new ProjetoDAO();
            FaseProjetoDAO fDao = new FaseProjetoDAO();

            carregarList();
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
                String projeto = ((Negocio.Models.Projeto)pDao.select(((Negocio.Models.FaseProjeto)fDao.select(atv.FaseProjetoId)).ProjetoId)).Titulo;

                to.SituacaoAtividade = situacao;
                to.NomeUsuario = usuario;
                to.TipoAtividade = tipoAtividade;
                to.NomeProjeto = projeto;

                listaRetorno.Add(to);
            }

            //gridAtv.Sort("NomeUsuario", SortDirection.Ascending);
            gridAtv.DataSource = listaRetorno;
            gridAtv.DataBind();
            if (listaRetorno.Count > 0) 
             agrupar(sender,e);
            

        }

        public void carregarList()
        {

            AtividadeDAO aDao = new AtividadeDAO();
            switch (rdBtnList.SelectedValue)
            {

                case "0":
                    {
                        lista = aDao.AtividadesAbertaPorUsuario();
                        break;
                    }
                case "1":
                    {
                        lista = aDao.AtividadesAbertaPorUsuario2();
                        break;
                    }
            }
        }

        public void agrupar(object sender, EventArgs e)
        {
            
                switch (rdBtnList.SelectedValue)
                {
                    case "0":
                        {
                            GridViewGrouper.GroupGridView(gridAtv.Rows, 0, 1);
                            break;
                        }
                    case "1":
                        {
                            GridViewGrouper.GroupGridView(gridAtv.Rows, 1, 2);
                            break;
                        }
                }
            
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