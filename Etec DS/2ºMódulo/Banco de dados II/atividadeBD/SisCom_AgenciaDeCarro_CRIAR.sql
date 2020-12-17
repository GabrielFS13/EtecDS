USE SisComAgenciaDeCarros

CREATE TABLE tbClientes(
cliCodigo int PRIMARY KEY NOT NULL,
cliNome varchar(50) not null,
cliFonePes int not null,
cliDtNasc datetime not null,
cliRG varchar(15) not null,
cliCPF varchar(18)
);

CREATE TABLE tbDepartamentos(
depCodigo int primary key not null,
depNome varchar(30) not null,
depDescricao varchar(100) not null
);
CREATE TABLE tbPais(
paisSigla varchar(3) primary key not null,
paisNome varchar(30) not null
);
CREATE TABLE tbEstados(
estSigla varchar(3) primary key not null,
estNome varchar(30) not null,
paisSigla varchar(3) foreign key references tbPais(paisSigla)
);

CREATE TABLE tbCidades(
cidSigla varchar(3) Primary key not null,
cidNome varchar(30) not null,
estSigla varchar(3) foreign key references tbEstados(estSigla)
);

CREATE TABLE tbBairros(
baiSigla varchar(3) Primary key not null,
baiNome varchar(30) not null,
cidSigla varchar(3) Foreign key references tbCidades(cidSigla)
);

CREATE TABLE tb_enderecos(
endCEP varchar(9) PRIMARY KEY not null,
endRUA varchar(50) not null,
baiSigla varchar(3) Foreign key references tbBairros(baiSigla)
);

CREATE TABLE tb_Fornecedores(
forCodigo int PRIMARY KEY NOT NULL,
forEmpresa varchar(50) not null,
forEmail varchar(50) not null,
forContato varchar(30) not null,
forFone varchar(10) not null,
forCNPJ varchar(18) not null,
forIE varchar(18),
forLO varchar(3) Foreign key references tbPais(paisSigla)
);

CREATE TABLE tbTipoPagamento(
tpgCodigo int PRIMARY KEY not null,
tpgDescricao varchar(20)
);

CREATE TABLE tbProdutos(
prodCodigo int PRIMARY KEY not null,
prodDescricao varchar(50) not null,
prodDescResumida varchar(15) not null,
prodQtAtual decimal not null,
prodValorVenda money not null
);
CREATE TABLE tbCargos(
carCodigo int primary key not null,
carNome varchar(50) not null,
carDescricao varchar(100) not null,
carViHora money
);

CREATE TABLE tbFuncionarios(
funCodigo int Primary key not null,
funNome varchar(50) not null,
endCEP varchar(9) foreign key references tb_enderecos(endCEP),
carCodigo int foreign key references tbCargos(carCodigo),
depCodigo int foreign key references tbDepartamentos(depCodigo),
fundDtNasc datetime not null,
fundDtAdmissao datetime not null
);

CREATE TABLE tbControlePedenciais(
cpdCodigo int PRIMARY KEY not null,
tpgCodigo int FOREIGN KEY REFERENCES tbTipoPagamento(tpgCodigo),
cliCodigo int FOREIGN KEY REFERENCES tbClientes(cliCodigo),
cpdNumero varchar(50) not null,
cpdValor money not null,
cpdDtCadastro datetime not null,
cpdPago bit not null,
cpdDtPagto smalldatetime not null
);

CREATE TABLE tbVendas(
venCodigo int primary key not null,
cliCodigo int foreign key references tbCLientes(cliCodigo),
funCodigo int foreign key references tbFuncionarios(funCodigo),
vemData datetime not null,
tpgCodigo int foreign key references tbTipoPagamento(tpgCodigo)
);
CREATE TABLE tbVendasAux(
auxCodigo int primary key not null,
venCodigo int foreign key references tbVendas(venCodigo),
prodCodigo int foreign key references tbProdutos(prodCodigo)
);