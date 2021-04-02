using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Aplicacao.Interfaces;
using JaliBackend.Aplicacao.Interfaces.Mappers;
using JaliBackend.Dominio.Core.Interfaces.Servicos;
using JaliBackend.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaliBackend.Aplicacao
{
    /// <summary>
    /// Classe de aplicação de Servico Genero
    /// </summary>
    public class AplicacaoServicoGenero : IAplicacaoServicoGenero
    {

        /// <summary>
        /// Interface de serviço genero
        /// </summary>
        private readonly IServicoGenero _servicoGenero;

        /// <summary>
        /// Interface de mapper Genero
        /// </summary>
        private readonly IMapperGenero _mapperGenero;

        /// <summary>
        /// Construtor com 2 parametros
        /// </summary>
        /// <param name="servicoGenero">Servico Genero</param>
        /// <param name="mapperGenero">Mapper Genero</param>
        public AplicacaoServicoGenero(IServicoGenero servicoGenero, IMapperGenero mapperGenero)
        {
            _servicoGenero = servicoGenero;
            _mapperGenero = mapperGenero;
        }

        /// <summary>
        /// Adicionar
        /// </summary>
        /// <param name="generoDto">generoDto</param>
        /// <returns>Task</returns>
        public async Task Adicionar(GeneroDto generoDto)
        {
            Genero genero = _mapperGenero.MapperDtoParaEntidade(generoDto);
            await _servicoGenero.Adicionar(genero);
        }

        /// <summary>
        /// Atualizar
        /// </summary>
        /// <param name="generoDto">generoDto</param>
        /// <returns>Task</returns>
        public async Task Atualizar(GeneroDto generoDto)
        {
            Genero genero = _mapperGenero.MapperDtoParaEntidade(generoDto);
            await _servicoGenero.Atualizar(genero);
        }

        /// <summary>
        /// ObterPorId
        /// </summary>
        /// <param name="id">Id a ser buscado</param>
        /// <returns>Genero encontrado</returns>
        public async Task<GeneroDto> ObterPorId(int id)
        {
            Genero genero = await _servicoGenero.ObterPorId(id);
            return _mapperGenero.MapperEntidadeParaDto(genero);
        }

        /// <summary>
        /// ObterTodos
        /// </summary>
        /// <returns>Lista de generos</returns>
        public async Task<IEnumerable<GeneroDto>> ObterTodos()
        {
            IEnumerable<Genero> generos = await _servicoGenero.ObterTodos();
            return _mapperGenero.MapperListaGeneroDtos(generos);
        }

        /// <summary>
        /// Remover
        /// </summary>
        /// <param name="generoDto">generoDto a ser removido</param>
        /// <returns>Task</returns>
        public async Task Remover(GeneroDto generoDto)
        {
            Genero genero = _mapperGenero.MapperDtoParaEntidade(generoDto);
            await _servicoGenero.Remover(genero);
        }
    }
}
