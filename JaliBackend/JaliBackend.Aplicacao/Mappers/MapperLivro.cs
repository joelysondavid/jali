using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Aplicacao.Interfaces.Mappers;
using JaliBackend.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace JaliBackend.Aplicacao.Mappers
{
    /// <summary>
    /// Classe para mapeamento do livro
    /// </summary>
    public class MapperLivro : IMapperLivro
    {
        /// <summary>
        /// Mapeia Obj DTO para Entidade
        /// </summary>
        /// <param name="livroDto">Obj Dto</param>
        /// <returns>Entidade</returns>
        public Livro MapperDtoParaEntidade(LivroDto livroDto)
        {
            Livro entidadeLivro = new Livro
            {
                Id = livroDto.Id,
                Titulo = livroDto.Titulo,
                Autor = livroDto.Autor,
                Resumo = livroDto.Resumo,
                Genero = new MapperGenero().MapperDtoParaEntidade(livroDto.Genero),
                Avaliacao = livroDto.Avaliacao,
                DataInicioLeitura = livroDto.DataInicioLeitura,
                DataConclusaoLeitura = livroDto.DataConclusaoLeitura,
                Status = Enum.Parse<Dominio.Entidades.LidoLendo>(livroDto.Status.ToString()),
            };

            return entidadeLivro;
        }

        /// <summary>
        /// Mapeia Obj Livro para livro dto
        /// </summary>
        /// <param name="livro">Livro</param>
        /// <returns>LivroDto</returns>
        public LivroDto MapperEntidadeParaDto(Livro livro)
        {
            LivroDto livroDto = new LivroDto
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                Autor = livro.Autor,
                Resumo = livro.Resumo,
                Genero = new MapperGenero().MapperEntidadeParaDto(livro.Genero),
                Avaliacao = livro.Avaliacao,
                DataInicioLeitura = livro.DataInicioLeitura,
                DataConclusaoLeitura = livro.DataConclusaoLeitura,
                Status = Enum.Parse<Aplicacao.Dtos.LidoLendo>(livro.Status.ToString()),
            };

            return livroDto;
        }

        /// <summary>
        /// Mapeia lista de livros para lista de livros dtos
        /// </summary>
        /// <param name="livros">Lista de livros</param>
        /// <returns>Lista de livros dtos</returns>
        public IEnumerable<LivroDto> MapperListaLivrosDto(IEnumerable<Livro> livros)
        {
            List<LivroDto> livrosDtos = new List<LivroDto>();

            foreach (Livro livro in livros)
            {
                livrosDtos.Add(MapperEntidadeParaDto(livro));
            }

            return livrosDtos;
        }
    }
}
