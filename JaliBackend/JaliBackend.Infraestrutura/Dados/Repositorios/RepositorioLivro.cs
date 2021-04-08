using JaliBackend.Dominio.Core.Interfaces.Repositorios;
using JaliBackend.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaliBackend.Infraestrutura.Dados.Repositorios
{
    /// <summary>
    /// Repositorio Livro
    /// </summary>
    public class RepositorioLivro : RepositorioBase<Livro>, IRepositorioLivro
    {
        /// <summary>
        /// Sql context
        /// </summary>
        private readonly SqlContext _sqlContext;

        /// <summary>
        /// Construtor com Sql context
        /// </summary>
        /// <param name="sqlContext">Sql context</param>
        public RepositorioLivro(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        /// <summary>
        /// Obter Todos Livros sobrescrito
        /// </summary>
        /// <returns></returns>
        public override async Task<IEnumerable<Livro>> ObterTodos()
        {
            IQueryable<Livro> query = _sqlContext.Livros.Include(l => l.Genero);

            return await query.ToArrayAsync();
        }
    }
}
