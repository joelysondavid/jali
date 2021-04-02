﻿using JaliBackend.Aplicacao.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaliBackend.Aplicacao.Interfaces
{
    /// <summary>
    /// Interface de aplicação de serviço de Genero
    /// </summary>
    public interface IAplicacaoServicoGenero
    {
        /// <summary>
        /// Adiciona
        /// </summary>
        /// <param name="genero">Genero a ser adicionado</param>
        /// <returns>Task</returns>
        Task Adicionar(GeneroDto genero);

        /// <summary>
        /// Atualizar
        /// </summary>
        /// <param name="genero">Genero a ser a tualizao</param>
        /// <returns>Task</returns>
        Task Atualizar(GeneroDto genero);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="genero">Genero a ser removido</param>
        /// <returns>Task</returns>
        Task Remover(GeneroDto genero);

        /// <summary>
        /// Obtem todos
        /// </summary>
        /// <returns>Todos Generos</returns>
        Task<IEnumerable<GeneroDto>> ObterTodos();

        /// <summary>
        /// Obtem por id
        /// </summary>
        /// <param name="id">Id do genero buscado</param>
        /// <returns>Genero encontrado</returns>
        Task<GeneroDto> ObterPorId(int id);
    }
}
