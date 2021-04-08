namespace JaliBackend.Dominio.Entidades
{
    /// <summary>
    /// Genero do livro
    /// </summary>
    public class Genero : Base
    {
        /// <summary>
        /// Tipo do genero narrativo do livro
        /// </summary>
        public string TipoGenero { get; set; }

        /// <summary>
        /// Breve descrição do genero
        /// </summary>
        public string Descricao { get; set; }
    }
}
