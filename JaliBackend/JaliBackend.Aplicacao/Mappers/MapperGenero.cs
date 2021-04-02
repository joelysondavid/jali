using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Aplicacao.Interfaces.Mappers;
using JaliBackend.Dominio.Entidades;
using System.Collections.Generic;

namespace JaliBackend.Aplicacao.Mappers
{
    public class MapperGenero : IMapperGenero
    {
        /// <summary>
        /// Mapeia Obj Dto para Entidade
        /// </summary>
        /// <param name="generoDto">GeneroDto</param>
        /// <returns>Genero</returns>
        public Genero MapperDtoParaEntidade(GeneroDto generoDto)
        {
            Genero entidadeGenero = new Genero
            {
                Id = generoDto.Id ?? 0,
                TipoGenero = generoDto.TipoGenero,
                Descricao = generoDto.Descricao,
            };

            return entidadeGenero;
        }

        /// <summary>
        /// Mapeia Obj Genero para Obj Genero Dto
        /// </summary>
        /// <param name="genero">Genero</param>
        /// <returns>LGeneroDto</returns>
        public GeneroDto MapperEntidadeParaDto(Genero genero)
        {
            GeneroDto generoDto = new GeneroDto
            {
                Id = genero.Id,
                TipoGenero = genero.TipoGenero,
                Descricao = genero.Descricao,
            };

            return generoDto;
        }

        /// <summary>
        /// Mapeia Lista de Generos para Lista de Generos Dtos
        /// </summary>
        /// <param name="generos">Generos</param>
        /// <returns>Generos Dtos</returns>
        public IEnumerable<GeneroDto> MapperListaGeneroDtos(IEnumerable<Genero> generos)
        {
            List<GeneroDto> generosDtos = new List<GeneroDto>();

            foreach (Genero genero in generos)
            {
                generosDtos.Add(MapperEntidadeParaDto(genero));
            }

            return generosDtos;
        }
    }
}
