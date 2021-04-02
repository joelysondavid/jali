using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Dominio.Entidades;
using System.Collections.Generic;

namespace JaliBackend.Aplicacao.Interfaces.Mappers
{
    /// <summary>
    /// Interface para mapeamento do livro
    /// </summary>
    public interface IMapperLivro
    {
        /// <summary>
        /// Mapeia obj Livro Dto para obj Livro entidade
        /// </summary>
        /// <param name="livroDto">Livro dto</param>
        /// <returns>Livro entidade</returns>
        Livro MapperDtoParaEntidade(LivroDto livroDto);

        /// <summary>
        /// Mapeia Livros para livros Dto
        /// </summary>
        /// <param name="livros">Lista de livros</param>
        /// <returns>Lista de Livros Dtos</returns>
        IEnumerable<LivroDto> MapperListaLivrosDto(IEnumerable<Livro> livros);

        /// <summary>
        /// Mapeia obj livro para obj livro dto
        /// </summary>
        /// <param name="livro">Livro </param>
        /// <returns>Livro dto</returns>
        LivroDto MapperEntidadeParaDto(Livro livro);
    }
}
