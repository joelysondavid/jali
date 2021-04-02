using JaliBackend.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace JaliBackend.Infraestrutura.Dados
{
    /// <summary>
    /// Sql context
    /// </summary>
    public class SqlContext : DbContext
    {
        /// <summary>
        /// Cosntrutor simples de Sql context
        /// </summary>
        public SqlContext() { }

        /// <summary>
        /// Coinstrutor com options sql context
        /// </summary>
        /// <param name="options"></param>
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        /// <summary>
        /// Conjunto de livros
        /// </summary>
        public DbSet<Livro> Livros { get; set; }

        /// <summary>
        /// Conjunto de Generos
        /// </summary>
        public DbSet<Genero> Generos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    // entry.Property("DataModificacao").IsModified = false;
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    // entry.Property("DataCadastro").IsModified = false;
                    // entry.Property("DataModificacao").IsModified = true;
                    entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
