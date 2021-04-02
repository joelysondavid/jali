using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace JaliBackend.Infraestrutura.CrossCutting.Interfaces
{
    /// <summary>
    /// Interface para mepeamento do genero
    /// </summary>
    public interface IMapperGenero
    {
        /// <summary>
        /// Mapeia Obj Dto para Entidade
        /// </summary>
        /// <param name="generoDto">GeneroDto</param>
        /// <returns>Genero</returns>
        Genero MapperDtoParaEntidade(GeneroDto generoDto);

        /// <summary>
        /// Mapeia Lista de Generos para Lista de Generos Dtos
        /// </summary>
        /// <param name="generos">Generos</param>
        /// <returns>Generos Dtos</returns>
        IEnumerable<GeneroDto> MapperListaGeneroDtos(IEnumerable<Genero> generos);

        /// <summary>
        /// Mapeia Obj Genero para Obj Genero Dto
        /// </summary>
        /// <param name="genero">Genero</param>
        /// <returns>GeneroDto</returns>
        GeneroDto MapperEntidadeParaDto(Genero genero);
    }
}
