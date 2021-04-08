using JaliBackend.Dominio.Core.Interfaces.Repositorios;
using JaliBackend.Dominio.Core.Interfaces.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaliBackend.Dominio.Servicos
{
    /// <summary>
    /// Serivoc Base
    /// </summary>
    /// <typeparam name="T">Obj Generico</typeparam>
    public class ServicoBase<T> : IServicoBase<T> where T : class
    {
        /// <summary>
        /// Interface de Repositorio base
        /// </summary>
        private readonly IRepositorioBase<T> _repositorio;

        /// <summary>
        /// Contrutor recebendo repositorio 
        /// </summary>
        /// <param name="repositorio">Repositorio base para injecao de dependencia</param>
        public ServicoBase(IRepositorioBase<T> repositorio)
        {
            _repositorio = repositorio;
        }

        /// <summary>
        /// Adicionar
        /// </summary>
        /// <param name="obj">Obj generico</param>
        /// <returns>Task</returns>
        public async Task Adicionar(T obj)
        {
            await _repositorio.Adicionar(obj);
        }

        /// <summary>
        /// Atualizar
        /// </summary>
        /// <param name="obj">Obj generico</param>
        /// <returns>Task</returns>
        public async Task Atualizar(T obj)
        {
            await _repositorio.Atualizar(obj);
        }

        /// <summary>
        /// Obtem obj generico por id
        /// </summary>
        /// <param name="id">Id do objeto</param>
        /// <returns>Objeto caso encontre</returns>
        public async Task<T> ObterPorId(int id)
        {
            return await _repositorio.ObterPorId(id);
        }

        /// <summary>
        /// Obtem todos obj 
        /// </summary>
        /// <returns>Lista de objetos encontrados</returns>
        public async Task<IEnumerable<T>> ObterTodos()
        {
            return await _repositorio.ObterTodos();
        }

        /// <summary>
        /// Remover obj
        /// </summary>
        /// <param name="obj">Obj generico</param>
        /// <returns>Task</returns>
        public async Task Remover(T obj)
        {
            await _repositorio.Remover(obj);
        }
    }
}
