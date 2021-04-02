using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaliBackend.Dominio.Core.Interfaces.Servicos
{
    /// <summary>
    /// Interface Servico Base
    /// </summary>
    public interface IServicoBase<T> where T : class
    {
        /// <summary>
        /// Adicionar generico
        /// </summary>
        /// <param name="obj">Objeto generico</param>
        /// <returns>Task</returns>
        Task Adicionar(T obj);

        /// <summary>
        /// Atualizar Generico
        /// </summary>
        /// <param name="obj">Obj generico</param>
        /// <returns>Task</returns>
        Task Atualizar(T obj);

        /// <summary>
        /// Remover Generico
        /// </summary>
        /// <param name="obj">Obj gnerico</param>
        /// <returns>Task</returns>
        Task Remover(T obj);

        /// <summary>
        /// Obter todos generico
        /// </summary>
        /// <returns>Lista enumerada</returns>
        Task<IEnumerable<T>> ObterTodos();

        /// <summary>
        /// Obter por id generico
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Objeto</returns>
        Task<T> ObterPorId(int id);
    }
}
