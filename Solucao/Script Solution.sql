CREATE DATABASE SOLUTION;

USE SOLUTION;

/***** TABELA USUARIOS *****/
CREATE TABLE tb_usuarios (
  id int auto_increment primary key,
  nome varchar(100),
  senha varchar (20),
  email varchar(200),
  setor varchar(50),
  localizacao varchar(100),
  perm1 varchar (2),
  perm2 varchar (2),
  perm3 varchar (2),
  perm4 varchar (2),
  perm5 varchar (2),
  perm6 varchar (2),
  perm7 varchar (2),
  perm8 varchar (2),
  perm9 varchar (2),
  perm10 varchar (2),
  perm11 varchar (2),
  perm12 varchar (2)
);
/*****************/

/***** CHAMADOS DOS USUARIOS E AGENTES *****/
CREATE TABLE tb_chamados (
  id int auto_increment primary key,
  solicitante varchar(100),
  responsavel varchar (20),
  status_chamado varchar(50),
  data_chamado varchar(15),
  urgencia varchar(20),
  hora varchar(10),
  titulo varchar(200),
  descricao varchar(900),
  equipamento varchar(100),
  setor varchar(100),
  localizacao varchar(100)
);
/*****************/

/***** TABELA DE CADASTROS SETOR *****/
CREATE TABLE tb_cadastros_setor(
    id int auto_increment primary key,
    definicao varchar(30),
    nome varchar(100),
    etiqueta varchar(50),
    tag varchar(50)
);
/*****************/

/***** TABELA DE CADASTROS LOCALIZACAO *****/
CREATE TABLE tb_cadastros_local(
    id int auto_increment primary key,
    definicao varchar(30),
    nome varchar(100),
    etiqueta varchar(50),
    tag varchar(50)
);
/*****************/

/***** TABELA DE MÁQUINAS *****/
CREATE TABLE tb_maquinas(
  id int auto_increment primary key,
  equipamento varchar(100),
  situacao varchar(20),
  localizacao varchar(100),
  setor varchar(100),
  ncm integer,
  plano varchar(150),
  garantia varchar(20)
  
);
/*****************/

/***** TABELA DE AÇÕES *****/
CREATE TABLE tb_chamados_acoes(
  id int auto_increment primary key,
  chamado integer,
  responsavel integer,
  visibilidade varchar (2),
  observacao varchar(900),
  custo decimal(7,2),
  atividade varchar(25),
  data_acao varchar(10),
  tempo_inicial varchar(10),
  tempo_final varchar(10),
  tempo_total varchar(10)
);
/*****************/

/***** INSERINDO A PRIMEIRA AÇÃO *****/
INSERT INTO tb_chamados (solicitante, responsavel, status_chamado, data_chamado, urgencia, hora, titulo, descricao, equipamento, setor, localizacao) 
VALUES ('Primeiro Chamado', 'Suporte', 'Cancelado', '27/04/2023', 'Alta', '20:42', 'Computador não liga', 'Tela Azul', 'Computador', 'Administrativo', 'Bloco A'); # Cancelado
/*****************/

/***** INSERINDO O PRIMEIRO USUÁRIO *****/
INSERT INTO tb_usuarios (nome, senha, email, perm1, perm2, perm3, perm4, perm5, perm6, perm7, perm8, perm9, perm10, perm11, perm12) 
VALUES ('Administrador', '1234', 'Administrador@adm.com', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S');
/*****************/

select id AS Login, senha AS Senha from tb_usuarios;