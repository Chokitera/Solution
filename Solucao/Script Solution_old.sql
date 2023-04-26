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

/***** PERMISSOES DOS USUARIOS *****/
CREATE TABLE tb_perm_usuarios (
  id int auto_increment primary key,
  usuario_id int,
  perm_id int,
  nome varchar(100),
  ativo varchar (2),

  FOREIGN KEY (usuario_id) REFERENCES tb_usuarios(id)
);
/*****************/
SELECT * FROM tb_usuarios;