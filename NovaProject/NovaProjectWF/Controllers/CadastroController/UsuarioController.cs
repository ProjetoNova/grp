using NovaProjectWF.Dao;
using NovaProjectWF.Models;
using NovaProjectWF.View.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaProjectWF.Controllers.CadastroController
{
    class UsuarioController
    {
        UsuarioDAO crud;

        public UsuarioController()
        {
            crud = new UsuarioDAO();
        }

        public List<string> TodosOsNomes()
        {
            List<String> nomes = new List<String>();

            foreach (Usuario t in crud.selectAll())
            {
                nomes.Add(t.Nome);
            }

            return nomes;
        }

        public Object Salvar(string Id, string Nome, string Formacao,
           string Experiencia, string Email, string Login, string senha, string confSenha,
           string Link, bool Status, int TipoUsuarioId)
        {
            int IdInt;
            if (Id != string.Empty)
            {
                IdInt = Convert.ToInt32(Id);
            }
            else
            {
                IdInt = 0;
            }

            if (Nome == string.Empty)
            {
                Mensagem.Erro("Nome não pode ser Nulo!");
            }
            else if (Login == string.Empty)
            {
                Mensagem.Erro("Login não pode ser Nulo!");
            }
            else if (senha == string.Empty)
            {
                Mensagem.Erro("Senha não pode ser Nula!");
            }
            else if (TipoUsuarioId == 0)
            {
                Mensagem.Erro("Tipo Usuario não pode ser Nulo!");
            }
            else if (!Validar.SenhasConferem(senha, confSenha))
            {
                Mensagem.Erro("Senhas não confere!");
            }
            else if (crud.selectLogin(IdInt, Login) != null)
            {
                Mensagem.Erro("Usuário já existe!");
                return null;
            }
            else
            {
                Usuario usuario = new Usuario();

                usuario.Nome = Nome;
                usuario.FormacaoAcademica = Formacao;
                usuario.ExperienciaSistema = Experiencia;
                usuario.Email = Email;
                usuario.Login = Login;
                usuario.Senha = senha;
                usuario.LinkExterno = Link;
                usuario.Status = Status;
                usuario.TipoUsuarioId = TipoUsuarioId;

                Object retorno = crud.save(IdInt, usuario);

                return retorno;
            }

            return null;
        }

        public Usuario BuscarPorId(string Id)
        {
            return (Usuario)crud.select(Convert.ToInt32(Id));
        }

        public List<Usuario> BuscarPorNome(string nome)
        {
            return (List<Usuario>)crud.selectNome(nome);
        }

        public List<Usuario> TodosOsDados()
        {
            return crud.selectAll();
        }

    }
}
