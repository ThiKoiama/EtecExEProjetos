/* Funções String */

/* ASCII - Retorna o valor do código ASCII do caractere*/

select ASCII('a')

select ASCII('Banana')

/* CHAR - Retorna o caractere ASCII*/

select CHAR(10)

/* LEN - Retorna o número de caracteres da expressão*/

select LEN ('banana')
use RecursosHumanos

select nome, len(nome)
from Funcionario

/* LEFT - Retorna a parte esquerda de uma cadeia de caracteres*/
select LEFT ('banana', 3)

select nome, cidade, left(nome, 3)+left(cidade,2)
from Funcionario

/* RIGHT - Retorna a parte direita de uma cadeia de caracteres*/
select RIGHT ('banana', 3)

select nome, cidade, RIGHT(nome, 3)+RIGHT(cidade,2)
from Funcionario

/* LOWER - Transforma para minúsculo*/
select LOWER ('BANANA')

/* UPPER - Transforma para MAIÚSCULO*/
select UPPER ('baNana')

/* SUBSTRING - Retorna uma parte da String*/
select SUBSTRING ('banana', 2, 4)

/* REPLACE - Substitui caracteres*/
select REPLACE ('banana', 'a', 'i')

/* LTRIM - remove espaços em branco à esquerda*/
select LTRIM ('    banana caramelada')

/* RTRIM - remove espaços em branco à direita*/
select RTRIM ('banana caramelada       ')