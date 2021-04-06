using System;

namespace JaliBackend.Aplicacao.Dtos
{
    /// <summary>
    /// Livro dto para exibição
    /// </summary>
    public class LivroDto
    {
        /// <summary>
        /// Id Livro
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Titulo Livro
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Autor do livro
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Resumo
        /// </summary>
        public string Resumo { get; set; }

        /// <summary>
        /// Genero do livro
        /// </summary>
        public GeneroDto Genero { get; set; }

        /// <summary>
        /// Avalição pessoal do livro
        /// </summary>
        public int? Avaliacao { get; set; }

        /// <summary>
        /// Data que iniciou ou irá iniciar a leitura do livro
        /// </summary>
        public DateTime? DataInicioLeitura { get; set; }

        /// <summary>
        /// Data de conclusão da leitura
        /// </summary>
        public DateTime? DataConclusaoLeitura { get; set; }

        /// <summary>
        /// Status lido lendo
        /// </summary>
        public LidoLendo Status { get; set; }
    }

    /// <summary>
    /// Enum lido/lendo para status
    /// </summary>
    public enum LidoLendo
    {
        /// <summary>
        /// Já Concluiu a leitura do livro
        /// </summary>
        Lido,

        /// <summary>
        /// Ainda está lendo o livro
        /// </summary>
        Lendo,

        /// <summary>
        /// Ainda vou ler
        /// </summary>
        VouLer
    }
}
