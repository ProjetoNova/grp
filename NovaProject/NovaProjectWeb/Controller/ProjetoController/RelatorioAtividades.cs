using Negocio.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//# Relatorio de Atividades (relAtividade.aspx)
//## Grafico com Quantidade de Atividades Abertas por Projeto


namespace NovaProjectWeb.Controller.ProjetoController
{
    public class RelatorioAtividades
    {
        AtividadeDAO atvDao;
        ProjetoDAO prjDao;
        UsuarioDAO usuDao;

        public RelatorioAtividades()
        {
            atvDao = new AtividadeDAO();
            prjDao = new ProjetoDAO();
            usuDao = new UsuarioDAO();
        }

        public List<Negocio.Models.Atividade> AtividadesPorUsuario()
        {
            return atvDao.AtividadesAgrupPorUsuario(); ;
        }
     
    }
}