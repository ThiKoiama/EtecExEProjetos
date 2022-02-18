
create database RecursosHumanos 
use RecursosHumanos
create table Funcionario
(
idfuncionario int not null, 
nome varchar(50), 
endereco varchar(100),
cidade varchar(50),
estado char (2),
email varchar (50) unique,
dataNascto date, 
primary key (idfuncionario)
)

alter table Funcionario	add salario decimal(7,2), cargo varchar(2) , ativo bit

-- Lista 2
insert into Funcionario 
(idfuncionario, nome, endereco, cidade, estado, email, dataNascto)
values
(5, 'Carlos Dias', 'Av. Lapa, 121', 'Itu', 'SP', 'carlao@gmail.com', '31-03-1990'),
(6, 'Ana Maria da Cunha', 'Av. S�o Paulo, 338', 'Itu', 'SP', 'aninhacunha@gmail.com', '12-04-1988'),
(7, 'Cl�udia Regina Martins', 'Rua Holanda, 89', 'Campinas' , 'SP', 'cregina@gmail.com', '04-12-1988'),
(8, 'Marcela Tatho', 'Rua B�lgica, 43', 'Campinas', 'SP', 'marctatho@hotmail.com', '09-11-1987'),
(9, 'Jorge Lu�s Rodrigues', 'Av. da Saudade, 1989', 'S�o Paulo', 'SP', 'jorgeluis@yahoo.com.br', '05-05-1990'),
(10, 'Ana Paula Camargo', 'Rua Costa e Silva, 33', 'Jundia�', 'SP', 'apcamargo@gmail.com', '30-06-1991'),
(11, 'Ivo Cunha', 'Av. Raio de Luz, 100', 'Campinas', 'SP', 'ivo@bol.com.br', '11-04-1987'),
(12, 'Carlos Lu�s de Souza', 'Rua Nicolau Coelho, 22', 'S�o Paulo', 'SP', 'cis@bol.com.br', '30-04-1988')

update Funcionario
set cidade='Valinhos'
where cidade='Itu'

update Funcionario
set cargo='AI', salario='1100'
where cidade='Valinhos'

update Funcionario
set cargo='PC', salario='1700'
where cidade='Campinas'

update Funcionario
set cargo='TI', salario='750'
where cidade='Jundia�'

select nome, cargo from Funcionario

select idfuncionario, email from Funcionario where estado='SP'

delete from Funcionario
where idfuncionario=5

select distinct cidade, estado from Funcionario where cargo='PC'

-- Lista 3
select nome, salario*1.30 from Funcionario

select nome, salario, salario*0.80 from Funcionario where cidade='Campinas'

select nome, salario from Funcionario where salario>1500

select nome, cidade from Funcionario where not cidade='Valinhos'

select idfuncionario, cidade from Funcionario where cidade='Valinhos' or cidade='Campinas'

select idfuncionario, cargo from Funcionario where not cidade='São paulo' and salario>=1000

select nome from Funcionario where cargo is not null

select nome, salario from Funcionario where salario between 500 and 1500

select nome, email from Funcionario where email like '%hotmail%'

select nome, email from Funcionario where email like '%.br' order by nome

select nome, email from Funcionario where email not like '%.com' order by nome

select nome, email from Funcionario where email like '__r%'

-- Lista 4
select nome, day(dataNascto) as dia, month(dataNascto) as mes, year(dataNascto) as ano from Funcionario

select distinct datename(month,dataNascto) as nome_mes from Funcionario order by nome_mes

select idfuncionario, nome from Funcionario where year(dataNascto)=1987

select nome, day(dataNascto) from Funcionario where month(dataNascto)=4 and year(dataNascto)=1988

select nome, dateadd(month,2,dataNascto) from Funcionario

select nome, datediff(year, dataNascto, getdate()) from Funcionario

select idfuncionario, nome, year(dataNascto) from Funcionario where (month(dataNascto) between 3 and 5) and year(dataNascto)=1990

select nome, year(dataNascto) from Funcionario where estado='SP'

select nome from Funcionario where year(dataNascto)<1990

select distinct cidade, estado from Funcionario where year(dataNascto)>1989

select * from Funcionario where year(dataNascto) in (1988,1990)

select nome from Funcionario where day(dataNascto)=30

-- Lista 5 
select nome, salario + pi() from Funcionario

select sqrt(day(dataNascto)) from Funcionario

select log(day(dataNascto)) from Funcionario where year(dataNascto)=1990

select nome, day(dataNascto) from Funcionario where power(day(dataNascto),3)>=1000

select round(salario + salario*0.155,0) from Funcionario where salario>1000

select abs(1500-salario) from Funcionario

select idfuncionario, sqrt(idfuncionario) from Funcionario where dataNascto <'1989-04-01'

select nome, round(salario-salario*0.35,1) from Funcionario

select log(idfuncionario) from Funcionario

select sqrt(idfuncionario) from Funcionario

select power(idfuncionario,2) from Funcionario

select abs(idfuncionario-10) from Funcionario order by idfuncionario desc

-- Lista 6

select upper(nome) from Funcionario

select distinct datename (month,dataNascto), len(datename(month,dataNascto)) from Funcionario

select replace(nome,' ','-') from Funcionario

select left(nome,3), right(nome,3) from Funcionario

select sqrt(len(nome)) from Funcionario

select distinct substring(cidade,3,5) from Funcionario 

select replace(nome, ' ','') from Funcionario

select char(idfuncionario) from Funcionario where cidade='Campinas'

select ascii(nome) from Funcionario where day(dataNascto)>20

select rtrim(left(cidade,4)) from  Funcionario

select ltrim(right(cidade,6)) from Funcionario

select distinct lower(cidade) from Funcionario







