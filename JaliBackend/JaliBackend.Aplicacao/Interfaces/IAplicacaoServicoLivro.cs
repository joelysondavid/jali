using JaliBackend.Aplicacao.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaliBackend.Aplicacao.Interfaces
{
    /// <summary>
    /// Interface de aplicação do livro
    /// </summary>
    public interface IAplicacaoServicoLivro
    {
        /// <summary>
        /// Adicionar livro
        /// </summary>
        /// <param name="livro">Livro a ser adicionado</param>
        /// <returns>Task</returns>
        Task Adicionar(LivroDto livro);

        /// <summary>
        /// Atualizar livro
        /// </summary>
        /// <param name="livro">Livro a ser</param>
        /// <returns>Task</returns>
        Task Atualizar(LivroDto livro);

        /// <summary>
        /// Remover livro
        /// </summary>
        /// <param name="livro">Livro a ser removido</param>
        /// <returns>Task</returns>
        Task Remover(LivroDto livro);

        /// <summary>
        /// Obtem todos os livros
        /// </summary>
        /// <returns>Todos os livros</returns>
        Task<IEnumerable<LivroDto>> ObterTodos();

        /// <summary>
        /// Obtem livro por id
        /// </summary>
        /// <param name="id">Id a ser buscado</param>
        /// <returns>Livro caso encontre</returns>
        Task<LivroDto> ObterPorId(int id);
    }
}
