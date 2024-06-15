-- Criação do banco de dados
CREATE DATABASE AvaliacaoDB;
GO

-- Seleciona o banco de dados AvaliacaoDB
USE AvaliacaoDB;
GO

-- Criação da tabela Clientes
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    Porte NVARCHAR(50) NOT NULL
);
GO

-- Inserção de registros na tabela Clientes
INSERT INTO Clientes (Nome, Porte) VALUES ('Empresa A', 'Pequena');
INSERT INTO Clientes (Nome, Porte) VALUES ('Empresa B', 'Média');
INSERT INTO Clientes (Nome, Porte) VALUES ('Empresa C', 'Grande');
INSERT INTO Clientes (Nome, Porte) VALUES ('Empresa D', 'Pequena');
GO


