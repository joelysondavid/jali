using JaliBackend.Aplicacao.Dtos;
using JaliBackend.Aplicacao.Interfaces;
using JaliBackend.Aplicacao.Interfaces.Mappers;
using JaliBackend.Dominio.Core.Interfaces.Servicos;
using JaliBackend.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JaliBackend.Aplicacao
{
    /// <summary>
    /// Classe de servico de aplicação
    /// </summary>
    public class AplicacaoServicoLivro : IAplicacaoServicoLivro
    {

        /// <summary>
        /// Interdace Serviço livro
        /// </summary>
        private readonly IServicoLivro _servicoLivro;


        /// <summary>
        /// Interdace mapper do livro
        /// </summary>
        private readonly IMapperLivro _mapperLivro;

        /// <summary>
        /// Construtor com Servico de livro e mapper de livro
        /// </summary>
        /// <param name="servicoLivro"></param>
        /// <param name="mapperLivro"></param>
        public AplicacaoServicoLivro(IServicoLivro servicoLivro, IMapperLivro mapperLivro)
        {
            _servicoLivro = servicoLivro;
            _mapperLivro = mapperLivro;
        }

        /// <summary>
        /// Adicionar
        /// </summary>
        /// <param name="livro">LivroDto</param>
        /// <returns>Task</returns>
        public async Task Adicionar(LivroDto livroDto)
        {
            Livro livro = _mapperLivro.MapperDtoParaEntidade(livroDto);
            await _servicoLivro.Adicionar(livro);
        }

        /// <summary>
        /// Atualizar 
        /// </summary>
        /// <param name="livro">LivroDto</param>
        /// <returns>Task</returns>
        public async Task Atualizar(LivroDto livroDto)
        {
            Livro livro = _mapperLivro.MapperDtoParaEntidade(livroDto);
            await _servicoLivro.Adicionar(livro);
        }

        /// <summary>
        /// Busca um livro por id
        /// </summary>
        /// <param name="id">Id do livro</param>
        /// <returns>Livro caso encontre</returns>
        public async Task<LivroDto> ObterPorId(int id)
        {
            Livro livro = await _servicoLivro.ObterPorId(id);

            return _mapperLivro.MapperEntidadeParaDto(livro);
        }

        /// <summary>
        /// Busca todos os livros 
        /// </summary>
        /// <returns>Todos livros encontrados</returns>
        public async Task<IEnumerable<LivroDto>> ObterTodos()
        {
            IEnumerable<Livro> livros = await _servicoLivro.ObterTodos();
            return _mapperLivro.MapperListaLivrosDto(livros);
        }

        /// <summary>
        /// Remover Livro
        /// </summary>
        /// <param name="livroDto">Livro Dto</param>
        /// <returns>Task</returns>
        public async Task Remover(LivroDto livroDto)
        {
            Livro livro = _mapperLivro.MapperDtoParaEntidade(livroDto);
            await _servicoLivro.Remover(livro);
        }
    }
}
