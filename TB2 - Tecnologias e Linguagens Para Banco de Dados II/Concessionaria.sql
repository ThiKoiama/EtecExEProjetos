create database Concessionaria

use Concessionaria

create table Veiculo (
chassi char(17) not null,
marca varchar(10) not null,
modelo varchar(20) not null,
anofabricacao int not null,
anomodelo int not null,
combustivel char(1) not null,
primary key (chassi)
)

alter table Veiculo	add dinheiro money not null, motor varchar(20) not null

alter table Veiculo drop column motor

create index MarcaMod on Veiculo (marca asc, modelo asc)

create index AnoFab on Veiculo (anofabricacao desc)

drop index MarcaMod on Veiculo

drop table Veiculo

drop database Concessionaria



