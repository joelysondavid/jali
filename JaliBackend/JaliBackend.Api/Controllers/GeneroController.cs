using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaliBackend.Api.Controllers
{
    /// <summary>
    /// Controller de Generos
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        /// <summary>
        /// Interface de Aplicacao de Serviço do Genero
        /// </summary>
        private readonly IAplicacaoServicoGenero _aplicacaoServicoGenero;

        /// <summary>
        /// Construtor com parametro de Aplicacao de Serviço do Genero
        /// </summary>
        /// <param name="aplicacaoServicoGenero">Interface de Aplicacao de Serviço do Genero</param>
        public GeneroController(IAplicacaoServicoGenero aplicacaoServicoGenero)
        {
            _aplicacaoServicoGenero = aplicacaoServicoGenero;
        }

        /// <summary>
        /// Endpoint para adicionar Genero de livros
        /// </summary>
        /// <param name="generoDto">Genero do livro</param>
        /// <returns>Status code da requisição</returns>
        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] GeneroDto generoDto)
        {
            try
            {
                if (generoDto == null)
                    return NotFound("Erro objeto de Genero vazio...");

                await _aplicacaoServicoGenero.Adicionar(generoDto);
                return Created("Genero adicionado com sucesso!", generoDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }

        /// <summary>
        /// Endpoint para atualização de Genero
        /// </summary>
        /// <param name="generoDto">Genero dto</param>
        /// <returns>Stats code da requisição</returns>
        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] GeneroDto generoDto)
        {
            try
            {
                if (generoDto == null)
                    return NotFound("Erro objeto de Genero vazio...");

                await _aplicacaoServicoGenero.Atualizar(generoDto);
                return Ok("Genero atualizado com sucesso!");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }

        /// <summary>
        /// Endpoint para remoção de genero
        /// </summary>
        /// <param name="generoDto">Genero dto</param>
        /// <returns>Status code da requisição</returns>
        [HttpDelete]
        public async Task<IActionResult> Remover([FromBody] GeneroDto generoDto)
        {
            try
            {
                if (generoDto == null || generoDto.Id == null)
                    return NotFound("Erro objeto de Genero vazio...");

                await _aplicacaoServicoGenero.Remover(generoDto);
                return Ok("Genero removido com sucesso!");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }

        /// <summary>
        /// Endpoint que busca genero por id
        /// </summary>
        /// <param name="id">Id do genero</param>
        /// <returns>Genero encontrado</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            try
            {
                GeneroDto generoDto = await _aplicacaoServicoGenero.ObterPorId(id);
                return Ok(generoDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }

        /// <summary>
        /// Endpoint que busca todos os generos
        /// </summary>
        /// <returns>Lista de generos encontrados</returns>
        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            try
            {
                IEnumerable<GeneroDto> generos = await _aplicacaoServicoGenero.ObterTodos();
                return Ok(generos);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }
    }
}
