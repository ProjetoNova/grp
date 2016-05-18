using Negocio.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//# Relatorio Tempo Gasto (tempoGasto.aspx)
//## Grafico Pizza com  Quantidade de tempos Gasto por Projeto.

namespace NovaProjectWeb.Controller.ProjetoController
{
    public class RelatorioTempoGasto
    {
        AtividadeDAO atvDao;
        ProjetoDAO prjDao;


        RelatorioTempoGasto()
        {
            atvDao = new AtividadeDAO();
            prjDao = new ProjetoDAO();
            
        }

        public List<Negocio.Models.Atividade> AtividadeTempoGasto()
        {
            return atvDao.TempoGastoAgrupPorProjeto(); ;
        }

    }
}