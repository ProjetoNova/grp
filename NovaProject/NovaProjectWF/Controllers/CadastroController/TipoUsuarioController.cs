﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaProjectWF.Models;
using NovaProjectWF.View.Utilitarios;
using NovaProjectWF.Dao;

namespace NovaProjectWF.Controllers.CadastroController
{
    class TipoUsuarioController
    {
        TipoUsuarioDAO crud;

        public TipoUsuarioController()
        {
            crud = new TipoUsuarioDAO();
        }

        public Object Salvar(string Id, string Nome, bool Status, bool Adm)
        {

            if (Id == string.Empty)
            {
                Id = "0";
            }

            if (Nome == string.Empty)
            {
                Mensagem.Erro("Nome não pode ser Nulo!");
            }
            else
            {
                TipoUsuario tipoUsuario = new TipoUsuario();

                tipoUsuario.Nome = Nome;
                tipoUsuario.Status = Status;
                tipoUsuario.Administrador = Adm;

                Object retorno = crud.save(Convert.ToInt32(Id), tipoUsuario);

                return retorno;
            }

            return null;
        }

        public TipoUsuario BuscarPorId(string Id)
        {
            return (TipoUsuario)crud.select(Convert.ToInt32(Id));
        }

        public List<TipoUsuario> BuscarPorNome(string nome)
        {
            return (List<TipoUsuario>)crud.selectNome(nome);
        }

        public List<TipoUsuario> TodosOsDados()
        {
            return crud.selectAll();
        }

        public List<string> TodosOsNomes()
        {
            List<String> nomes = new List<String>();

            foreach (TipoUsuario t in crud.selectAll())
            {
                nomes.Add(t.Nome);
            }

            return nomes;
        }

    }
}
