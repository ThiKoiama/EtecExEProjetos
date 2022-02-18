--1
SELECT nome, dataNasc, cidade from alunos;

--2
SELECT nome, email, matricula from professores;

--3
SELECT nome, nomeComponente from curso where serie=1

--4
SELECT rm, nome FROM aluno INNER JOIN matricula WHERE alunos.rm = matricula.rm INNER JOIN cursos where cursos.matricula = matricula.matricula 
SELECT rm, nome FROM alunos, matricula, curso WHERE alunos.rm = matricula.rm  and curso.rm = matricula.rm 