-- Cria��o do banco de dados
CREATE DATABASE AvaliacaoDB;
GO

-- Seleciona o banco de dados AvaliacaoDB
USE AvaliacaoDB;
GO

-- Cria��o da tabela Clientes
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    Porte NVARCHAR(50) NOT NULL
);
GO

-- Inser��o de registros na tabela Clientes
INSERT INTO Clientes (Nome, Porte) VALUES ('Empresa A', 'Pequena');
INSERT INTO Clientes (Nome, Porte) VALUES ('Empresa B', 'M�dia');
INSERT INTO Clientes (Nome, Porte) VALUES ('Empresa C', 'Grande');
INSERT INTO Clientes (Nome, Porte) VALUES ('Empresa D', 'Pequena');
GO


