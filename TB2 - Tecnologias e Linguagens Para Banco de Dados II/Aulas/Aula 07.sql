/*Funções de Agregação - Cap 7 */

use RecursosHumanos


select * from funcionario

/* COUNT: retorna a quantidade de registros da coluna especificada */
select count(*) from funcionario

select count(distinct cidade) as cidadeDiferente
from Funcionario


select  cidade, count(*) as qtde
from Funcionario
group by cidade
order by qtde desc



select count(*) as qtde, cidade, cargo
from Funcionario
group by cidade,cargo
order by qtde

select count(distinct cidade) as total
from funcionario




/* SUM: Retorna a soma dos valores de uma coluna*/
select sum(salario) as 'soma dos salarios'
from funcionario
where cidade = 'Itu' or cidade='Jundiaí'

select * from funcionario

select sum(salario) as soma, salario from funcionario
group by salario


/* AVG: Retorna a média dos valores de uma coluna*/
select avg(salario) as 'média dos salarios'
from funcionario
group by salario
 

/* MAX: Retorna o maior  valor de uma coluna*/
select max(salario) as 'maior salario'
from funcionario
where cidade='Jundiaí'
 
/* MIN: Retorna o menor  valor de uma coluna*/
select min(salario) as 'menor salario'
from funcionario
 