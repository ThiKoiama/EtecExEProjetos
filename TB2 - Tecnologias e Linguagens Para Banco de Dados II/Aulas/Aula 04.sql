/*Aula 04
********* FUNÇÕES DE DATA E HORA ************
*/
/* GetDate: Retorna o valor da data atual do sistema */
Select GETDATE()

/* Day: Retorna o DIA de uma data fornecida*/
Select day('2016-12-25')

Select nome, DAY(dataNascto), dataNascto
from Funcionario


/* Month: Retorna o MÊS de uma data fornecida*/
Select month('2016-12-25')

Select nome, MONTH(dataNascto), dataNascto
from Funcionario
where Month(dataNascto) = 1

/* Year: Retorna o ANO de uma data fornecida*/
Select nome, YEAR(dataNascto), dataNascto
from Funcionario

select *
from funcionario
where month(dataNascto) = 11

/* DateAdd: Adiciona um determinado número a uma parte da data
Parte:
Year - ano
Quarter - trimestre
month - mês
Dayofyear - dia do ano
Day - dia
Week - semana
WeekDay - dia da semana
Hour - hora
Minute - minuto
Second - segundo
Milisecond - milisegundos
*/
Select DATEADD(day, 5, GETDATE())


/*DateDiff: apresenta a diferença de dias, meses ou anos entre duas datas*/
select DATEDIFF(day, '2018-01-01', getdate())

/*DateName: apresenta o nome da parte da data*/
select DATENAME (month, getdate())

