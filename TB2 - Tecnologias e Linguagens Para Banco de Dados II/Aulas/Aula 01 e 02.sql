/* Script Banco de Dados e  criação da estrutura da tabela */
create database RecursosHumanos

use RecursosHumanos

create table Funcionario(
	idFuncionario int not null,
	nome varchar(50) not null,
	endereco varchar(100) null,
	cidade varchar(50) null,
	estado char(2) null,
	email varchar(100) null unique,
	dataNascto date null,
	cargo char(2) null,
	primary key (idFuncionario))

	select * from funcionario

	select nome, endereco from funcionario

	/* alter table - modifica a estrutura da tabela */

	alter table funcionario add
	salario decimal(10,2) null,
	cargos varchar(2) null

	alter table funcionario drop column cargos

	alter table funcionario add
	cargo char(2) null

	/* drop table - exclui a tabela */

	drop table funcionario

	/* drop database - exclui o banco de dados */

	drop database RecursosHumanos2M

	use Master
	drop database RecursosHumanos2M

   /* create index - cria uma estrutura de índice para um
   determinado campo*/


   use RecursosHumanos2M
   create index indnome on funcionario (nome)

   create index indendereco on funcionario (endereco desc)


   /* drop index - exclui um índice existente*/ 

   drop index indendereco on funcionario







Capítulo 2 

/* inserir dados na tabela */
insert into Funcionario 
(idFuncionario, nome, endereco, cidade, estado, email, dataNascto)
values
(1, 'José da Silva', 'Av. São Paulo', 'Itu', 'SP', 'zesilva@yahoo.com.br',
'1991-02-24')

insert into Funcionario
values
(2, 'Byuhl Gueittys', 'Av. Maicroçofiti, 95', 'Janela', 'SP',
 'emeiodobiu@epow.com', '1965-12-25')

insert into Funcionario
(idFuncionario, nome, endereco, cidade, estado, email, dataNascto)
values
(5, 'Ana Maria Souza', 'Av. das Nações da Paz', 'ONU', 'US', 'iloveny@boom.com',
'1950-01-01'),
(6, 'Maria de Fátima', 'Rua das Maçãs', 'Apple City', 'US', 'me@me.com',
'1990-01-01'), 
(7, 'José Maria de Oliveira', 'Av. das Nações da Paz', 'ONU', 'US', 'iloveny@boom.com',
'1950-01-01'),
(8, 'André dos Santos Maria', 'Rua das Maçãs', 'Apple City', 'US', 'me@me.com',
'1990-01-01') 

/* atualiza os dados da tabela (alteração)*/
update Funcionario
set nome = 'Jonas Bróders', endereco = 'Av. das Nações da Paz'
where idFuncionario = 3

update funcionario
set estado = 'SP'

/* exclui os dados da tabela (exclusão)*/
delete from funcionario
where idFuncionario = 3

/* exibe todos os campos e todos os registros da tabela*/
select * from funcionario

/* exibe nome, cidade, datanascto dos funcionários da cidade de itu
ordenados em ordem crescente de datanascto */
select nome, cidade, dataNascto
from funcionario
where cidade='Itu'
order by dataNascto 

/* exibe todos os campos e todos os registros da tabela do 
estado de sp */
select * 
from Funcionario
where estado = 'SP'