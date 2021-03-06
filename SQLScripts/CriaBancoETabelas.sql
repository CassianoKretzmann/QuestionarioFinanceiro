CREATE DATABASE QuestionarioClientes
GO
USE QuestionarioClientes
GO
CREATE TABLE FaixaEtaria
(
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Descricao VARCHAR(50)
)
GO
CREATE TABLE Convenio
(
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Descricao VARCHAR(50)
)
GO
CREATE TABLE FaixaSalarial
(
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Descricao VARCHAR(50)
)
GO
CREATE TABLE MotivoEmprestimo
(
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Descricao VARCHAR(50)
)
GO
CREATE TABLE Respostas
(
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FaixaEtariaId INT FOREIGN KEY REFERENCES FaixaEtaria(Id),
	ConvenioId INT FOREIGN KEY REFERENCES Convenio(Id),
	FaixaSalarialId INT FOREIGN KEY REFERENCES FaixaSalarial(Id),
	MotivoEmprestimoId INT FOREIGN KEY REFERENCES MotivoEmprestimo(Id),
)
GO