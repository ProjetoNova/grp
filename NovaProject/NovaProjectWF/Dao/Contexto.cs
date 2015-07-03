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

        public DbSet<Anexo> Anexo { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
        public DbSet<FaseProjeto> FaseProjeto { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<TipoAtividade> TipoAtividade { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioProjeto> UsuarioProjeto { get; set; }
       
    }
}
