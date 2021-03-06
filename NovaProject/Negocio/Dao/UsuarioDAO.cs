﻿using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Dao
{
    public class UsuarioDAO : CRUD<Usuario>
    {
        public Usuario login(string login, string senha)
        {
            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.USUARIO_
                            where c.Login == login 
                            && c.Senha == senha
                            && c.Status == true
                            select c;

                foreach (var item in query)
                {
                    return item;
                }
            }

            return null;
        }

        public List<Usuario> selectNome(string nome)
        {
            List<Usuario> usuario = new List<Usuario>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.USUARIO_
                            where c.Nome.Contains(nome)
                            select c;

                foreach (var item in query)
                {
                    usuario.Add(item);
                }
            }

            return usuario;
        }

        public Usuario selectLogin(int idAtual, string login)
        {
            Usuario usuario = null;

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.USUARIO_
                            where c.Login.Contains(login)
                            && c.Id != idAtual
                            select c;

                usuario = query.FirstOrDefault<Usuario>();
            }

            return usuario;
        }

        public List<Usuario> selectAtivos()
        {
            List<Usuario> usuario = new List<Usuario>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.USUARIO_
                            where c.Status == true
                            select c;

                foreach (var item in query)
                {
                    usuario.Add(item);
                }
            }

            return usuario;
        }

        public override List<Usuario> selectAll()
        {
            List<Usuario> allUsuario = new List<Usuario>();

            using (Contexto ctx = new Contexto())
            {
                var query = from c in ctx.USUARIO_ select c;

                foreach (var item in query)
                {
                    allUsuario.Add(item);
                }
            }

            return allUsuario;
        }
    }
}
