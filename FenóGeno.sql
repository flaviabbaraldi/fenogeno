CREATE DATABASE FENOGENO
GO

USE FENOGENO
GO

CREATE TABLE OLHOS(
	ID			INTEGER PRIMARY KEY IDENTITY(1,1),
	DESCRICAO	VARCHAR(50)
)

INSERT INTO OLHOS
VALUES
('Azul'),
('Castanho'),
('Verde');

SELECT * FROM OLHOS;

CREATE TABLE CABELO(
	ID			INTEGER PRIMARY KEY IDENTITY(1,1),
	DESCRICAO	VARCHAR(50)
)

INSERT INTO CABELO
VALUES
('Castanho'),
('Loiro'),
('Preto'),
('Ruivo');

SELECT * FROM CABELO;

CREATE TABLE PELE(
	ID				INTEGER PRIMARY KEY IDENTITY(1,1),
	DESCRICAO		VARCHAR(50)
);

INSERT INTO PELE
VALUES
('Pele clara'),
('Pele escura');

SELECT * FROM PELE;

CREATE TABLE GRUPO_SANGUINEO(
ID			INTEGER PRIMARY KEY IDENTITY(1,1),
DESCRICAO	VARCHAR(50)
)

INSERT INTO GRUPO_SANGUINEO
VALUES
('A'),
('AB'),
('B'),
('O');

SELECT * FROM GRUPO_SANGUINEO;

CREATE TABLE FATOR_RH(
	ID			INTEGER PRIMARY KEY IDENTITY(1,1),
	DESCRICAO	VARCHAR(50)
)

INSERT INTO FATOR_RH
VALUES
('+'),
('-');

SELECT * FROM FATOR_RH;

CREATE TABLE ESPECIALISTA(
	COD				INTEGER IDENTITY(1,1) PRIMARY KEY,
	CRM				VARCHAR(50),
	CPF				VARCHAR(50),
	NOME			VARCHAR(300),
	EMAIL			VARCHAR(250),
	TELEFONE		VARCHAR(50),
	CURSO_F			VARCHAR(100),
	UNIVERSIDADE_C	VARCHAR(200),
	DURACAO_C		VARCHAR(50),
	ANO_INICIO_C	INTEGER,
	ANO_TERMINO_C	INTEGER,
	AREA_E			VARCHAR(200),
	UNIVERSIDADE_E	VARCHAR(200),
	DURACAO_E		VARCHAR(50),
	ANO_INICIO_E	INTEGER,
	ANO_TERMINO_E	INTEGER,
	FOTO			VARCHAR(2000)
);

SELECT * FROM ESPECIALISTA;

CREATE TABLE NOTICIA(
	COD				INTEGER IDENTITY(1,1) PRIMARY KEY ,
	TITULO			VARCHAR(100),
	DESCRICAO		VARCHAR(300),
	CORPO_TEXTO		VARCHAR(MAX),
	FOTO			VARCHAR(2000)
);

SELECT * FROM NOTICIA;

CREATE TABLE USUARIO(
	ID				INTEGER IDENTITY(1,1) PRIMARY KEY,
	NOME			VARCHAR(200),
	EMAIL			VARCHAR(200),
	SENHA			VARCHAR(10),
	CIDADE			VARCHAR(500),
	BAIRRO			VARCHAR(500),
	FOTO			VARCHAR(2000),
	ADMINISTRADOR	BIT DEFAULT 0
);

INSERT INTO USUARIO (NOME, SENHA, EMAIL, ADMINISTRADOR)
VALUES ('ADMINISTRADOR', '123', 'ADMIN@FENOGENO.COM.BR', 1);

SELECT * FROM USUARIO;
SELECT * FROM NOTICIA;

CREATE TABLE COMENTARIO(
	ID			INTEGER IDENTITY(1,1) PRIMARY KEY,
	ID_NOTICIA	INTEGER REFERENCES NOTICIA(COD),	
	ID_USUARIO	INTEGER REFERENCES USUARIO(ID),
	DATAHORA	DATETIME,
	TEXTO		VARCHAR(MAX)
);

SELECT * FROM COMENTARIO;

CREATE TABLE ANOMALIA(
	ID			INTEGER IDENTITY(1,1) PRIMARY KEY, 
	DESCRICAO	VARCHAR(100)
);

INSERT INTO ANOMALIA
VALUES
('Polidactilia'),
('Doen�a de Huntington'),
('Doen�a de Hippel'),
('Daltonismo'),
('Albinismo'),
('Hemofilia');