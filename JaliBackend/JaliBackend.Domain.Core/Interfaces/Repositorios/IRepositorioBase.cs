using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaliBackend.Dominio.Core.Interfaces.Repositorios
{
    /// <summary>
    /// Interface Repositorio base
    /// </summary>
    public interface IRepositorioBase<T> where T : class
    {
        /// <summary>
        /// Método abstrato de adição de genericos
        /// </summary>
        /// <param name="obj">Obj abstrato</param>
        Task Adicionar(T obj);

        /// <summary>
        /// Busca todos genericos
        /// </summary>
        /// <returns>Todos elementos</returns>
        Task<IEnumerable<T>> ObterTodos();

        /// <summary>
        /// Obtém generico por id
        /// </summary>
        /// <param name="id">Id do obj</param>
        /// <returns>Objeto buscado caso encontre</returns>
        Task<T> ObterPorId(int id);

        /// <summary>
        /// Atualiza generico específico
        /// </summary>
        /// <param name="obj">Objeto alterado</param>
        Task Atualizar(T obj);

        /// <summary>
        /// Remove generico
        /// </summary>
        /// <param name="obj">Objeto para remoção</param>
        Task Remover(T obj);
    }
}
