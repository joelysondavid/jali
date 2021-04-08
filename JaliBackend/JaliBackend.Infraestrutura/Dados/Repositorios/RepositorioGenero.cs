using JaliBackend.Dominio.Core.Interfaces.Repositorios;
using JaliBackend.Dominio.Entidades;

namespace JaliBackend.Infraestrutura.Dados.Repositorios
{
    /// <summary>
    /// Repositorio Genero
    /// </summary>
    public class RepositorioGenero : RepositorioBase<Genero>, IRepositorioGenero
    {
        /// <summary>
        /// Sql context
        /// </summary>
        private readonly SqlContext _sqlContext;

        /// <summary>
        /// Construtor com Sqlcontext
        /// </summary>
        /// <param name="sqlContext">Sql context</param>
        public RepositorioGenero(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
