CREATE DATABASE projeto 

USE projeto

-- Cria��o das Tabelas
CREATE TABLE usuario (
	id_usuario INT IDENTITY PRIMARY KEY,
	nome_usuario VARCHAR(200) NOT NULL,
	idade_usuario INT NOT NULL,
	email_usuario VARCHAR(250) NOT NULL UNIQUE,
	senha_usuario VARCHAR(250) NOT NULL
)

CREATE TABLE tipo_avaliacao (
	id_avaliacao INT IDENTITY PRIMARY KEY,
	titulo VARCHAR (50) NOT NULL UNIQUE,
	descricao VARCHAR(250),	
)

CREATE TABLE avaliador(
	id_avaliador INT IDENTITY PRIMARY KEY,
	nome_avaliador VARCHAR(250) NOT NULL UNIQUE,
	funcao VARCHAR(250) NOT NULL
)

CREATE TABLE avaliacao (
	id_avaliacao INT FOREIGN KEY REFERENCES tipo_avaliacao(id_avaliacao),
	id_usuario INT FOREIGN KEY REFERENCES usuario(id_usuario),
	nota DECIMAL NOT NULL,
	id_avaliador INT FOREIGN KEY REFERENCES avaliador(id_avaliador)
)

-- Comando para deletar tabelas 
DROP TABLE usuario

DROP TABLE tipo_avaliacao

DROP TABLE avaliador

DROP TABLE avaliacao

