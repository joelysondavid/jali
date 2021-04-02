using JaliBackend.Dominio.Core.Interfaces.Repositorios;
using JaliBackend.Dominio.Core.Interfaces.Servicos;
using JaliBackend.Dominio.Entidades;

namespace JaliBackend.Dominio.Servicos
{
    /// <summary>
    /// Classe de Serviço do Livro
    /// </summary>
    public class ServicoLivro : ServicoBase<Livro>, IServicoLivro
    {
        /// <summary>
        /// Interface Repositorio livro para injeção de dependência
        /// </summary>
        private readonly IRepositorioLivro repositorioLivro;

        public ServicoLivro(IRepositorioLivro repositorio) : base(repositorio)
        {
            repositorioLivro = repositorio;
        }
    }
}
