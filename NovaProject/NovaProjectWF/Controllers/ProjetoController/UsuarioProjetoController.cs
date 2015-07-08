using NovaProjectWF.Dao;
using NovaProjectWF.Models;
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

                objRetorno = crud.save(Convert.ToInt32("0"), up);
            }

            return objRetorno;
        }

        public UsuarioProjeto GetUsuarioProjeto(int ProjetoId, int UsuarioId)
        {
            crud = new UsuarioProjetoDAO();

            return crud.GetUsuarioProjeto(ProjetoId, UsuarioId);
        }

        public List<UsuarioProjeto> GetUsuariosDoProjeto(int ProjetoId)
        {
            crud = new UsuarioProjetoDAO();
            TipoUsuarioDAO tuDao = new TipoUsuarioDAO();
            UsuarioDAO uDao = new UsuarioDAO();

            List<UsuarioProjeto> lista = crud.GetUsuariosDoProjeto(ProjetoId);

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Papel = (TipoUsuario)tuDao.select(lista[i].TipoUsuarioId.Value);
                lista[i].Usuario = (Usuario)uDao.select(lista[i].UsuarioId.Value);
            }
            return lista;
        }

        public List<string> GetNomesDoProjeto(int ProjetoId)
        {
            crud = new UsuarioProjetoDAO();
            TipoUsuarioDAO tuDao = new TipoUsuarioDAO();
            UsuarioDAO uDao = new UsuarioDAO();

            List<UsuarioProjeto> lista = GetUsuariosDoProjeto(ProjetoId);
            List<string> listaReturn = new List<string>();

            foreach (var usuario in lista)
            {
                listaReturn.Add(((UsuarioProjeto)usuario).Usuario.Nome);
            }

            return listaReturn;
        }
    }
}
