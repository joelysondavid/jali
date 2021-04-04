USE JaliDDD

CREATE TABLE [dbo].[Livros]
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Titulo VARCHAR(50) NOT NULL,
	Resumo VARCHAR(255) NULL,
	Autor VARCHAR(50) NOT NULL,
	DataCadastro DATETIME NOT NULL,
	DataModificacao DATETIME NULL,
	DataInicioLeitura DATETIME NULL,
	DataConclusaoLeitura DATETIME NULL,
	Status TINYINT NOT NULL,
	Avaliacao TINYINT NULL,
	GeneroId INT,
	FOREIGN KEY (GeneroId) REFERENCES Generos(Id)
);

SELECT * FROM LIVROS