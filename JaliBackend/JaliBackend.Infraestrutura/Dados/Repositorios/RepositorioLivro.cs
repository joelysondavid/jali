using JaliBackend.Dominio.Core.Interfaces.Repositorios;
using JaliBackend.Dominio.Entidades;

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
    }
}
