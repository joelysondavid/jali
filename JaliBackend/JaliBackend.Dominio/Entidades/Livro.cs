using System;

namespace JaliBackend.Dominio.Entidades
{
    /// <summary>
    /// Livro
    /// </summary>
    public class Livro : Base
    {
        /// <summary>
        /// Título do livro
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Autor do livro
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Genero do livro
        /// </summary>
        public string Genero { get; set; }

        /// <summary>
        /// Breve resumo para lembraça de pontos relevantes do livro
        /// </summary>
        public string Resumo { get; set; }

        /// <summary>
        /// Avaliação do livro
        /// </summary>
        public int? Avaliacao { get; set; }


        /// <summary>
        /// Data que iniciou a leitura do livro
        /// </summary>
        public DateTime? DataInicioLeitura { get; set; }

        /// <summary>
        /// Data que terminou de ler o livro
        /// </summary>
        public DateTime? DataConclusaoLeitura { get; set; }

        /// <summary>
        /// Data de cadastro do livro...
        /// </summary>
        public DateTime? DataCadastro { get; set; }

        /// <summary>
        /// Data de Atualizacao do cadastro de livro
        /// </summary>
        public DateTime? DataModificacao { get; set; }

        /// <summary>
        /// Lido/Lendo
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
        /// Vai ler
        /// </summary>
        VouLer,
    }
}
