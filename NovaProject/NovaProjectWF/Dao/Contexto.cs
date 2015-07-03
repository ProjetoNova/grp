namespace NovaProjectWF.Dao
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using NovaProjectWF.Models;

    class Contexto : DbContext
    {
        public Contexto() : base("name=Modelo")
        {

        }

        public DbSet<Atividade> ATIVIDADE_ { get; set; }
        public DbSet<FaseProjeto> FASE_PROJETO_ { get; set; }
        public DbSet<Projeto> PROJETO_ { get; set; }
        public DbSet<TipoAtividade> TIPO_ATIVIDADE_ { get; set; }
        public DbSet<TipoUsuario> TIPO_USUARIO_ { get; set; }
        public DbSet<UsuarioDAO> USUARIO_ { get; set; }
        public DbSet<UsuarioProjetoDAO> USUARIO_PROJETO { get; set; }

        public class MyInitializer : DropCreateDatabaseIfModelChanges<Contexto>
        {
        }

    }


}
