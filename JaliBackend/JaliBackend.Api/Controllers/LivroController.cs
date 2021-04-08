using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaliBackend.Api.Controllers
{
    /// <summary>
    /// Controller de Livros
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {

        /// <summary>
        /// Interface de aplicação de Serviço Livro
        /// </summary>
        private readonly IAplicacaoServicoLivro _aplicacaoServicoLivro;

        /// <summary>
        /// Construtor com parametro de aplicacao de servico livro
        /// </summary>
        /// <param name="aplicacaoServicoLivro">aplicacao de servico livro</param>
        public LivroController(IAplicacaoServicoLivro aplicacaoServicoLivro)
        {
            _aplicacaoServicoLivro = aplicacaoServicoLivro;
        }

        /// <summary>
        /// Endpoint de inclusão de livro
        /// </summary>
        /// <param name="livroDto">Livro Dto</param>
        /// <returns>Status Code da requisição</returns>
        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] LivroDto livroDto)
        {
            try
            {
                if (livroDto == null)
                    return NotFound("Erro objeto livro vazio");

                await _aplicacaoServicoLivro.Adicionar(livroDto);
                return Created("Livro cadastrado com sucesso!", livroDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }

        /// <summary>
        /// Endpoint para atualização de livros
        /// </summary>
        /// <param name="livroDto">Livro a ser atualizado</param>
        /// <returns>Status code da requisição</returns>
        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] LivroDto livroDto)
        {
            try
            {
                if (livroDto == null)
                    return NotFound("Erro objeto livro vazio");

                await _aplicacaoServicoLivro.Atualizar(livroDto);
                return Ok("Livro atualizado com sucesso!");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }

        /// <summary>
        /// Endpoint para remoção de livros
        /// </summary>
        /// <param name="livroDto">Livro a ser removido</param>
        /// <returns>Status code da requisição</returns>
        [HttpDelete]
        public async Task<IActionResult> Remover([FromBody] LivroDto livroDto)
        {
            try
            {
                if (livroDto == null || livroDto.Id == null)
                    return NotFound("Erro objeto livro vazio");

                await _aplicacaoServicoLivro.Remover(livroDto);
                return Ok("Livro removido com sucesso!");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }

        /// <summary>
        /// Endpoint que busca livro por id
        /// </summary>
        /// <param name="id">id do livro buscado</param>
        /// <returns>Livro encontrado</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            try
            {
                LivroDto livroDto = await _aplicacaoServicoLivro.ObterPorId(id);
                return Ok(livroDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }

        /// <summary>
        /// Endpoint que busca todos os livros
        /// </summary>
        /// <returns>Lista de livros encontrados</returns>
        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            try
            {
                IEnumerable<LivroDto> livros = await _aplicacaoServicoLivro.ObterTodos();
                return Ok(livros);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro na requisição, favor entre em contato comigo mesmo...");
            }
        }
    }
}
