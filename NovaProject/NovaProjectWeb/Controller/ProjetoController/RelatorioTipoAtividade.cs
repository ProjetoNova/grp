using Negocio.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//# Relatorio Tipo de Atividade (tipoAtividade.aspx)
//## Grafico Pizza com a Quantidade de Atividades separadas por tipo

namespace NovaProjectWeb.Controller.ProjetoController
{
    public class RelatorioTipoAtividades
    {
        AtividadeDAO atvDao;
        ProjetoDAO prjDao;
        UsuarioDAO usuDao;
        TipoAtvidadeDAO tipDao;

        RelatorioTipoAtividades()
        {
            atvDao = new AtividadeDAO();
            prjDao = new ProjetoDAO();
            usuDao = new UsuarioDAO();
            tipDao = new TipoAtvidadeDAO();
        }

        public List<Negocio.Models.Atividade> AtividadesPorTipo()
        {
            return atvDao.AtividadesAgrupPorTipo(); ;
        }

    }
}