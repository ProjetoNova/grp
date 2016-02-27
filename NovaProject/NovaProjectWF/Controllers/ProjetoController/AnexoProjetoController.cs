using NovaProjectWF.Controllers.CadastroController;
using NovaProjectWF.Dao;
using NovaProjectWF.Models;
using NovaProjectWF.Models.NaoPersistido;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Controllers.ProjetoController
{
    class AnexoProjetoController
    {
        AnexoProjetoDAO crud;

        public AnexoProjetoController()
        {
            crud = new AnexoProjetoDAO();
        }

        public Object Salvar(string Id, int projetoId, int usuarioId, StreamReader sr, 
            DateTime data,string fileName, string Observacoes)
        {
            if (Id.Equals(""))
            {
                Id = "0";
            }

            AnexoProjeto artefato = new AnexoProjeto();
            artefato.ProjetoId = projetoId;
            artefato.UsuarioId = usuarioId;
            artefato.Anexo = sr.CurrentEncoding.GetBytes(sr.ReadToEnd());
            artefato.Data = data;
            artefato.NomeArquivo = fileName;

            AnexoProjetoDAO apDao = new AnexoProjetoDAO();

            return apDao.save(Convert.ToInt32(Id), artefato);
        }

        public List<ArtefatosProjeto> getArtefatoPorProjeto(int ProjetoId)
        {
            List<AnexoProjeto> anexos = crud.GetArtefatosDoProjeto(ProjetoId);
            List<ArtefatosProjeto> artefatos = new List<ArtefatosProjeto>();

            UsuarioController uC = new UsuarioController();
            ProjetoController pC = new ProjetoController();

            foreach(AnexoProjeto a in anexos)
            {
                ArtefatosProjeto artefato = new ArtefatosProjeto();
                artefato.IdAnexo = a.Id;
                artefato.NomeArquivo = a.NomeArquivo;
                artefato.TamanhoArquivo = a.Anexo.Length;
                artefato.DataArquivo = a.Data;
                artefato.Responsavel = uC.BuscarPorId(a.UsuarioId+"").Nome;
                artefato.Projeto = pC.BuscarPorId(a.ProjetoId + "").Titulo;
                artefato.Observacoes = a.Observacoes;

                artefatos.Add(artefato);
            }

            return artefatos;
        }

    }
}
