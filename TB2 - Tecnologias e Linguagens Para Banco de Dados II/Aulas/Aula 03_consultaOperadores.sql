/* Aula 3 */

use recursoshumanos

select *from funcionarios


/* Todos os funcionarios cujo cargo seja ti ter�o 10% de 
acrescimo. Exiber nome, salario e novosalario.*/

select nome, salario, salario * 1.10 as novosalario 
from funcionarios
where cargo = 'ti'

/* Exibir nome e endereco de todos os funcionarios que n�o moram em jundiai*/

select idfuncionario, nome, endereco 
from funcionarios
where cidade != 'jundiai'

/*Exibir os salarios entre 2000 e 3000 */

select nome, salario 
from funcionarios
where salario >=2000 and salario<=3000

select nome, salario
from funcionarios
where salario between 2000 and 3000

/* Exibir os funcionarios que moram em jundai ou Campinas*/

select nome, cidade
from funcionarios
where cidade = 'jundiai' or cidade = 'valinhos'

select *from funcionarios

/* Exibir os nomes dos funcionarios que comecem com a e n�o importa
o nome do funcionario*/
select nome from funcionarios
where nome like 'a%'

/*Exibir o nome do funcionario que deve come�ar com A e ter na 5 posi��o a
letra m, o resto n�o importa*/

select nome from funcionarios
where nome like 'a___m%'

/* Encontre em nome em qualquer posi��o os caracteres re*/
select nome from funcionarios
where nome like '%re%'

/* Encontre em nome o nome cunha em qualquer posi��o*/
select nome from funcionarios
where nome like '%Cunha%'


/* Atualiza o campo email para nulo* os idfuncianrio menor ou
igual a 2*/
update funcionarios
set email=null
where idfuncionario<=2


/* Verifica o campo email � nulo */
select nome, email from funcionarios
where email is null

select *from funcionarios

/* Verifica se alguem mora em itu e jundiai*/
select *from funcionarios
where cidade in('itu', 'jundiai')

