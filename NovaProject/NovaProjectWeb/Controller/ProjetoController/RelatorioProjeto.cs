using Negocio.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//# Relatorio de Projetos (relProjeto.aspx)
//## Grafico de linha com o tempo Gasto de todos os projetos (Abertos)

namespace NovaProjectWeb.Controller.ProjetoController
{
    public class RelatorioAProjeto
    {
        AtividadeDAO atvDao;
        ProjetoDAO prjDao;

        RelatorioAProjeto()
        {
            atvDao = new AtividadeDAO();
            prjDao = new ProjetoDAO();
        
        }

        public List<Negocio.Models.Projeto> ProjetosRelatorio ()
        {
            return prjDao.ProjetosRelatorio(); ;
        }

//        public List<Negocio.Models.Atividade> AtividadesProjeto()
  //      {
    //        return atvDao.AtividadesAgrupProjeto(); ;
      //  }

    }
}