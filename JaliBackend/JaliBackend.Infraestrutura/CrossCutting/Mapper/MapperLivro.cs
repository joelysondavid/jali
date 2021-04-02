using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Dominio.Entidades;
using JaliBackend.Infraestrutura.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JaliBackend.Infraestrutura.CrossCutting.Mapper
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
                Id = livroDto.Id ?? 0,
                Titulo = livroDto.Titulo,
                Autor = livroDto.Autor,
                Resumo = livroDto.Resumo,
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
