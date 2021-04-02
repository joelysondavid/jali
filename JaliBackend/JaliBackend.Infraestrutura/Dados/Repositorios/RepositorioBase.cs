using JaliBackend.Dominio.Core.Interfaces.Repositorios;
using JaliBackend.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaliBackend.Infraestrutura.Dados.Repositorios
{
    /// <summary>
    /// Repositorio Base
    /// </summary>
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        /// <summary>
        /// Sqlcontext somente leitura
        /// </summary>
        private readonly SqlContext _sqlContext;

        /// <summary>
        /// Construtor recebe sqlcontext
        /// </summary>
        /// <param name="sqlContext"></param>
        public RepositorioBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        /// <summary>
        /// Adicionar generico
        /// </summary>
        /// <param name="obj">Obj generico para adicionar</param>
        /// <returns>Task</returns>
        public async Task Adicionar(T obj)
        {
            try
            {
                await _sqlContext.Set<T>().AddAsync(obj);
                await _sqlContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Atualizar generico
        /// </summary>
        /// <param name="obj">Obj generico para atualização</param>
        /// <returns>Task</returns>
        public async Task Atualizar(T obj)
        {
            try
            {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                await _sqlContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Remove obj generico
        /// </summary>
        /// <param name="obj">Objeto generico a ser removido</param>
        /// <returns>Task</returns>
        public async Task Remover(T obj)
        {
            try
            {
                _sqlContext.Set<T>().Remove(obj);
                await _sqlContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obter generico por id
        /// </summary>
        /// <param name="id">Chave identificadora</param>
        /// <returns>Objeto encontrado</returns>
        public async Task<T> ObterPorId(int id)
        {
            try
            {
                return await _sqlContext.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtem todos os objetos do tipo passado
        /// </summary>
        /// <returns>Lista de objetos genericos</returns>
        public async Task<IEnumerable<T>> ObterTodos()
        {
            try
            {
                return await _sqlContext.Set<T>().ToArrayAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
