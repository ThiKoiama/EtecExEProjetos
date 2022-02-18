create database Empresa

use Empresa

create table Fornecedores(
CodFor int identity,
Empresa varchar(40),
Contato varchar(30),
Cargo varchar(30),
Endereco varchar(60),
Cidade varchar(15),
CEP varchar(10),
Pais varchar(15),
primary key(CodFor))

create table Categorias(
CodCategoria int identity,
Descr varchar(50),
primary key(CodCategoria))

create table Clientes(
CodCli char(5),
Nome varchar(40),
Contato varchar(30),
Cargo varchar(30),
Endereco varchar(60),
Cidade varchar(15),
Regiao varchar(15),
CEP varchar(10), 
Pais varchar(15),
Telefone varchar(24),
Fax varchar(24),
primary key(CodCli))

create table Funcionarios(
CodFun int identity,
Sobrenome varchar(20),
Nome varchar(10),
Cargo varchar(30),
DataNasc date,
Endereco varchar(60),
Cidade varchar(15),
CEP varchar(10),
Pais varchar(15),
Fone varchar(24),
salario money default(0.0),
primary key (CodFun))

create table Produtos(
CodProd int identity,
Descr varchar(40),
CodFor int,
CodCategoria int,
Preco money default(0.0),
Unidades smallint default(0),
Descontinuado bit,
primary key (CodProd),
foreign key(CodFor) references Fornecedores(CodFor) on delete cascade,
foreign key(CodCategoria) references Categorias(CodCategoria) on delete cascade,
)

create table Pedidos(
NumPed int,
CodCli char(5),
CodFun int,
DataPed date,
DataEntrega date,
Frete money default(0.0),
primary key(NumPed),
foreign key(CodCli) references Clientes(CodCli) on delete cascade,
foreign key(CodFun) references Funcionarios(CodFun) on delete cascade,
)

create table DetalhesPed(
NumPed int,
CodProd int,
Preco money default(0.0),
Qtde smallint,
Desconto float,
primary key(NumPed, CodProd),
foreign key(NumPed) references Pedidos(NumPed) on delete cascade,
foreign key(CodProd) references Produtos(CodProd) on delete cascade,

)