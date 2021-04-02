using JaliBackend.Dominio.Core.Interfaces.Repositorios;
using JaliBackend.Dominio.Core.Interfaces.Servicos;
using JaliBackend.Dominio.Entidades;

namespace JaliBackend.Dominio.Servicos
{
    /// <summary>
    /// Classe de Serviço de Genêro de livro
    /// </summary>
    public class ServicoGenero : ServicoBase<Genero>, IServicoGenero
    {
        /// <summary>
        /// Repositorio de Genero
        /// </summary>
        private readonly IRepositorioGenero repositorioGenero;

        /// <summary>
        /// Construtor com repositorio genero
        /// </summary>
        /// <param name="repositorio">Repositorio Genero para injeção de dependência</param>
        public ServicoGenero(IRepositorioGenero repositorio) : base(repositorio)
        {
            repositorioGenero = repositorio;
        }
    }
}
