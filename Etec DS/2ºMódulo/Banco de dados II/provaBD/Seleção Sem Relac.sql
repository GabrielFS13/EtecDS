--1) Criar um Banco de Dados com o nome SisAcad (1,0)
/*
 CREATE DATABASE SisAcad
 */
 --2) Criar 4 tabelas, dentro do Banco de Dados SisAcad, utilizando as seguintes estruturas: (8,0)
 /*
 USE SisAcad

CREATE TABLE tbAlunos(aluRA INT PRIMARY KEY NOT NULL, aluNome VARCHAR(50) NOT NULL, aluRG VARCHAR(15), aluDtNasc DATETIME);

CREATE TABLE tbMateria(matCodigo INT PRIMARY KEY, matNome VARCHAR(50) NOT NULL);

CREATE TABLE tbTurma(turSequencia INT PRIMARY KEY,turCodigo VARCHAR(2), aluRA INT, turPeriodo VARCHAR(15));

CREATE TABLE tbNotas(notSequencia INT PRIMARY KEY, aluRA INT, matCodigo INT, notNota REAL);
*/

--3) Inserir os registros a seguir, em cada tabela: (8,0)
/*
USE SisAcad

INSERT INTO tbAlunos (aluRA,aluNome,aluRG,AluDtNasc)
	VALUES(12345,'José Antonio','33.456.234-2',12/09/1998),
		  (23456,'Antonio Cesar','25.212.675-6',05/03/1975),
		  (34567,'Cesar Lemos','41.434.615-4',23/10/1997);	

INSERT INTO tbMateria(matCodigo,matNome)
	VALUES (100,'Português'),
		   (200,'Matemática'),
		   (300,'Inglês');

INSERT INTO tbTurma(turSequencia,turCodigo,aluRA,turPeriodo)
		VALUES (1,'1A',12345,'Diurno'),
			   (2,'1A',23456,'Diurno'),
			   (3,'1B',34567,'Tarde');

INSERT INTO tbNotas (notSequencia,aluRA,matCodigo,notNota)
	VALUES (1,12345,100,8.5),
		   (2,12345,200,6.5),
		   (3,12345,300,9.0),
		   (4,23456,100,9.5),
		   (5,23456,200,8.0),
		   (6,23456,300,8.0),
		   (7,34567,100,7.5),
		   (8,34567,200,5.5),
		   (9,34567,300,6.0)

*/

--4)	Mostre todos os campos da tabela tbTurma, com a saída formatada e ordenada por turma e Código do aluno. (2,0)
/*

SELECT * FROM tbTurma ORDER BY turCodigo,aluRA ASC;

*/
--5)	Mostre as notas de todas as disciplinas de todos os alunos, com a saída formatada e ordenada por código do aluno e código da disciplina. (3,0)
/*

SELECT * FROM tbNotas ORDER BY aluRA,matCodigo DESC;

*/
--6)	Sabendo que a média é 7,0, mostre todos os alunos que tiveram a nota abaixo da média, exibindo: Código da matéria, Código do Aluno, e a respectiva nota, com a saída formatada e ordenada por código do aluno e disciplina. (3,0)
/*
SELECT matCodigo,aluRA,notNota FROM tbNotas WHERE notNota < 7 
	ORDER BY aluRA ASC;

*/
