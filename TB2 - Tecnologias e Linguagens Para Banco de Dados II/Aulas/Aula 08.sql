/* Agupamento de Dados GROUP BY */
select sum(salario), cidade, estado
from Funcionario
group by cidade, estado

select count(*), sum(salario), max(salario), cidade
from funcionario
group by cidade

select cidade, count(*) as qtde
from Funcionario
group by cidade
order by qtde desc

select cidade, count(*) as qtde
from Funcionario
group by cidade
having count(*) > =2

