namespace JaliBackend.Aplicacao.Dtos
{
    /// <summary>
    /// Classe de genero para exibição
    /// </summary>
    public class GeneroDto
    {
        /// <summary>
        /// Id do genero
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Tipo do genero
        /// </summary>
        public string TipoGenero { get; set; }

        /// <summary>
        /// Descrição do genero
        /// </summary>
        public string Descricao { get; set; }
    }
}
