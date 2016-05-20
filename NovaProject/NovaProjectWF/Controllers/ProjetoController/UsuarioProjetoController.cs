using Negocio.Dao;
using Negocio.Models;
using Negocio.Models.NaoPersistido;
using NovaProjectWF.View.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Controllers.ProjetoController
{
    class UsuarioProjetoController
    {
        UsuarioProjetoDAO crud;

        public Object Salvar(int TipoUsuarioId, int ProjetoId, int UsuarioId)
        {
            Object objRetorno = null;

            if (GetUsuarioProjeto(ProjetoId, UsuarioId) != null) 
            {
                Mensagem.Erro("Usuário já consta no Projeto!");
            }
            else 
            {
                crud = new UsuarioProjetoDAO();

                UsuarioProjeto up = new UsuarioProjeto();

                up.UsuarioId = UsuarioId;
                up.ProjetoId = ProjetoId;
                up.TipoUsuarioId = TipoUsuarioId;
                up.Observacao = "";
                up.InicioProjeto = DateTime.Now;
                up.FimProjeto = DateTime.Now;
                up.Status = true;

                objRetorno = crud.save(Convert.ToInt32("0"), up);
            }

            return objRetorno;
        }

        public Object Update(Negocio.Models.UsuarioProjeto UsuarioProjetoId, int TipoUsuarioId, 
                                            DateTime dataInicio, DateTime dataFim, bool Ativo, string obs)
        {
            UsuarioProjeto up = new UsuarioProjeto();

            up.UsuarioId = UsuarioProjetoId.UsuarioId;
            up.ProjetoId = UsuarioProjetoId.ProjetoId;
            up.TipoUsuarioId = TipoUsuarioId;
            up.InicioProjeto = dataInicio;
            up.FimProjeto = dataFim;
            up.Status = Ativo;
            up.Observacao = obs;
            crud = new UsuarioProjetoDAO();
            Object objRetorno = null;
            objRetorno = crud.save(UsuarioProjetoId.Id, up);

            return objRetorno;
        }

        public UsuarioProjeto GetUsuarioProjeto(int ProjetoId, int UsuarioId)
        {
            crud = new UsuarioProjetoDAO();

            return crud.GetUsuarioProjeto(ProjetoId, UsuarioId);
        }

        public List<EquipeProjeto> GetUsuariosDoProjeto(int ProjetoId)
        {
            crud = new UsuarioProjetoDAO();
            TipoUsuarioDAO tuDao = new TipoUsuarioDAO();
            UsuarioDAO uDao = new UsuarioDAO();

            List<UsuarioProjeto> lista = crud.GetUsuariosDoProjeto(ProjetoId);
            List<EquipeProjeto> listaRetorno = new List<EquipeProjeto>();

            for (int i = 0; i < lista.Count; i++)
            {
                EquipeProjeto equipe = new EquipeProjeto();
                equipe.Papel = ((TipoUsuario)tuDao.select(lista[i].TipoUsuarioId.Value)).Nome;
                equipe.NomeUsuario = ((Usuario)uDao.select(lista[i].UsuarioId.Value)).Nome;
                listaRetorno.Add(equipe);
            }
            return listaRetorno;
        }

        public List<string> GetNomesDoProjeto(int ProjetoId)
        {
            crud = new UsuarioProjetoDAO();
            TipoUsuarioDAO tuDao = new TipoUsuarioDAO();
            UsuarioDAO uDao = new UsuarioDAO();

            List<EquipeProjeto> lista = GetUsuariosDoProjeto(ProjetoId);
            List<string> listaReturn = new List<string>();

            foreach (var usuario in lista)
            {
                listaReturn.Add(((EquipeProjeto)usuario).NomeUsuario);
            }

            return listaReturn;
        }

        public Object ExcluirUsuario(int usuarioProjetoId)
        {
            crud = new UsuarioProjetoDAO();
            return crud.delete((UsuarioProjeto)crud.select(usuarioProjetoId));
            
        }
    }
}
