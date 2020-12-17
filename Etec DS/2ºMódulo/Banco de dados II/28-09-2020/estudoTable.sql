USE ExerciciosCriaçãoDeTabelas
CREATE TABLE tbDep (Codigo int Primary Key Not null,
					Nome character(25) Not null)

CREATE TABLE tbProd (Codigo int Primary Key Not null,
					 Empresa character(50) Not null,
					 Email character(50),
					 Cidade character(30))

CREATE TABLE tbFornec(Codigo int Primary Key Not null,
					  Empresa character(50) Not null,
					  Email character(50),
					  Cidade character(30))

CREATE TABLE tbCli(Codigo int Primary Key Not null,
				   Nome character(50) Not null,
				   Email character(50),
				   Fone character(15))

CREATE TABLE tbMovimento (movCod int Primary Key Not null,
					      cliCod int Foreign Key REFERENCES tbcli(Codigo),
						  funCod int Foreign Key REFERENCES tbFornec(Codigo),
						  movData datetime)

CREATE TABLE tbMovimAux(auxCod int Primary Key Not null,
						MovCod int Foreign Key REFERENCES tbMovimento(movCod),
						prodCod int Foreign Key REFERENCES tbProd(Codigo),
						auxQuant real)