CREATE DATABASE JaliDDD;
GO
USE JaliDDD
GO

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
	Status INT NOT NULL,
	Avaliacao INT NULL,
	Genero VARCHAR(30) NOT NULL,
	-- GeneroId INT,
	-- FOREIGN KEY (GeneroId) REFERENCES Generos(Id)
);

SELECT * FROM LIVROS

INSERT INTO LIVROS VALUES ('Titulo', 'Resumo', 'jojoe', '04/04/2021 18:55:55', NULL, NULL, NULL, 1, 10, 'DALEE');


CREATE TABLE [dbo].[Generos]
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TipoGenero VARCHAR(40) NOT NULL,
	Descricao VARCHAR(255) NULL
)

SELECT * FROM GENEROS