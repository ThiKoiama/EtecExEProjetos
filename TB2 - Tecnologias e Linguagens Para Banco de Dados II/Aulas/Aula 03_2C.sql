use RecursosHumanos2M_2_2017

select * from Funcionario

/* CONSULTAS COM OPERADORES */
/* Operadores Aritm�ticos 
	+	|	Soma
	-	|	Subtra��o
	*	|	Multiplica��o
	/	|	Divis�o
	%	|	Resto de Divis�o
*/
select 1 + 2 as soma 

select (1 + 5) * 3 as resultado

select 12 * 7 as mult, 12 + 7 as soma, 12 - 7 as sub

use RecursosHumanos

select *from funcionario

/*acrescentar os campos cargo e salario*/

alter table funcionario drop column  ativo
alter table funcionario add ativo bit

update funcionario set ativo = 1


alter table funcionario
add cargo char(2) null,
salario decimal(7,2) null

update Funcionario set salario = 1100
where idfuncionario = 2

 select nome, salario from funcionario
 where idfuncionario = 1

update Funcionario set salario = salario * 1.08
where idFuncionario = 1

select nome, salario * 1.08 from funcionario
where idfuncionario = 1

select nome, salario, salario + 100 as NovoSalario
from Funcionario

update Funcionario set salario = salario + 100

/*Operadores Relacionais

		>	|	maior
		<	|	menor
		=	|	igual
   != ou <>	|	diferente
		>=	|	maior ou igual
		<=	|	menor ou igual
*/
/* Operadores L�gicos

and - e
or - ou
not - n�o */

select nome, salario, estado
from Funcionario
where (salario >= 1100 and salario <=1180) or estado = 'SP'
 
select nome, cidade
from Funcionario
where  cidade = 'Itu'

select *
from Funcionario
where  cidade <> 'Janela'

/*Operadores Auxiliares
	IS NULL - Verifica se uma coluna � vazia
	BETWEEN - Verifica uma faixa de valores
	IN	    - Verifica se um valor existe na tabela
	LIKE	- Verifica um valor buscando semelhantes

	_ substitui um caracter na posi��o espec�fica
	% substitui zero ou um conjunto de caracteres

*/

select nome, salario
from Funcionario
where (salario between 100 and 900)

select * 
from Funcionario
where cargo is  null


select nome
from Funcionario
where nome like  'Ana%'

select nome from funcionario
where nome like '____m%'

select nome, email from funcionario
where email like '%@hotmail%'

select * 
from Funcionario
where estado in ( 'MG', 'RS', 'RJ')

