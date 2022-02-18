-- Exercícios - TB3

use Empresa3M2019

select 






/*Utilizando o Banco de Dados: Empresa3M realize as seguintes
consultas:*/




/*01) Exiba o nome e o cargo de todos os funcionários dos EUA e o
contato e o cargo de todos os fornecedores dos EUA (Usando UNION)*/

select * from Funcionarios

select * from Fornecedores

select funcionarios.Nome, funcionarios.Cargo, 'funcionarios' as tipo from funcionarios
where funcionarios.pais = 'EUA'
UNION
select fornecedores.contato, fornecedores.Cargo, 'fornecedores' as tipo from fornecedores
where fornecedores.pais = 'EUA' 

order by tipo


02) Exiba nome, contato e país de todos os clientes do Brasil e da
Alemanha (Usando UNION)
select 

select Clientes.Nome, Clientes.contato, Clientes.Pais from clientes  where Clientes.Pais='Brasil'
union
select Clientes.Nome, Clientes.contato, Clientes.Pais from clientes where Clientes.Pais='Alemanha'
order by Clientes.pais

03) Exiba o nome, o cargo e o país de todos os funcionários do Reino
Unido e o contato e o cargo de todos os fornecedores da França

/*04) Exiba a Descrição do produto e a descrição da categoria que ele
pertence.*/

select * from produtos
select * from categorias

select produtos.Descr, categorias.descr from produtos, categorias
where produtos.codCategoria = categorias.Codcategoria

select produtos.Descr, categorias.descr from produtos 
inner join categorias
on Produtos.CodCategoria = Categorias.CodCategoria

/*05) Exiba todos os dados dos produtos da categoria bebidas em ordem
crescente de descrição.*/
select * from produtos
select * from categorias

select Produtos.* from Produtos, Categorias
where Produtos.CodCategoria = Categorias.CodCategoria and Categorias.Descr='Bebidas'
order by Produtos.Descr asc



/*06) Mostre todos os dados dos pedidos feitos pelo cliente 'Queen
Cozinha' em fevereiro de 1998.*/

select * from Clientes
select * from pedidos

select Pedidos.* from pedidos, clientes
where Pedidos.CodCli = Clientes.CodCli and Clientes.Nome = 'Queen Cozinha' and Month(Pedidos.DataPed) = 2 and year(Pedidos.DataPed) = 1998

/*07) Exiba todos os dados dos pedidos que continham o produto 'Tofu'.
Em ordem de data de pedido. */

select * from pedidos
select * from Produtos

Select * from DetalhesPed
where CodProd=14

select Pedidos.*, Produtos.Descr, Produtos.codprod from pedidos,DetalhesPed, produtos
where DetalhesPed.CodProd = Produtos.CodProd and Produtos.Descr = 'Tofu'
order by Pedidos.DataPed desc





/*08) Exiba o nome da empresa do fornecedor e a quantidade de produtos
por fornecedor.*/

select * from Fornecedores
select * from pedidos
select * from produtos

select Fornecedores.Empresa, count(*) as qtde
from Fornecedores, produtos
where Fornecedores.Codfor = Produtos.Codfor
group by Fornecedores.Empresa


09) Exiba todos os dados dos produtos comprados pelo cliente cujo
contato seja 'Paula Wilson'

select * from produtos
select * from clientes
select * from Pedidos
select * from DetalhesPed

select Produtos.* from Produtos, Clientes, Pedidos
where Clientes.CodCli= Pedidos.CodCli and Clientes.Contato='Paula Wilson'

10) Mostre soma, média, maior e menor frete dos pedidos feitos pelo
cliente 'Queen Cozinha'.
select sum(Pedidos.Frete) as soma, avg(pedidos.frete) as média, max(pedidos.frete) as maior, min(pedidos.frete) as menor
from Pedidos, Clientes
where Pedidos.CodCli = clientes.CodCli and Clientes.Nome = 'Queen Cozinha'
