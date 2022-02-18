/* Fun��es String */

/* ASCII - Retorna o valor do c�digo ASCII do caractere*/

select ASCII('a')

select ASCII('Banana')

/* CHAR - Retorna o caractere ASCII*/

select CHAR(10)

/* LEN - Retorna o n�mero de caracteres da express�o*/

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

/* LOWER - Transforma para min�sculo*/
select LOWER ('BANANA')

/* UPPER - Transforma para MAI�SCULO*/
select UPPER ('baNana')

/* SUBSTRING - Retorna uma parte da String*/
select SUBSTRING ('banana', 2, 4)

/* REPLACE - Substitui caracteres*/
select REPLACE ('banana', 'a', 'i')

/* LTRIM - remove espa�os em branco � esquerda*/
select LTRIM ('    banana caramelada')

/* RTRIM - remove espa�os em branco � direita*/
select RTRIM ('banana caramelada       ')