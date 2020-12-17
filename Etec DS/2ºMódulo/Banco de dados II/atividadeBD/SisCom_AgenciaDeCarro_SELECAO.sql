USE SisComAgenciaDeCarros

--//1 - Mostrar todos os clientes, funcionários, fornecedores, produtos, por ordem alfabética de nome.										

/*

SELECT cliNome,FunNome,forEmpresa,prodDescricao 
FROM tbClientes,tbFuncionarios,tb_Fornecedores,tbProdutos 
ORDER BY cliNome,FunNome,forEmpresa,prodDescricao ASC






--//2 - Mostrar as cidades de São Paulo e Rio de Janeiro em ordem alfabética (nome da cidade e depois estado).											

SELECT cidNome FROM tbCidades
WHERE estSigla = 'SP' OR estSigla = 'RJ' 
ORDER BY cidNome,estSigla






--//3 - Mostrar todos os produtos com quantidade menor que 10, ordenados e com formatação na saída.		

SELECT * FROM tbProdutos 
WHERE prodQtAtual<10 
ORDER BY prodQtAtual ASC







--//4 - Mostrar o valor de todos os itens de cada produto no estoque. Mostrar apenas os campos código, descrição e valor total ordenado e formatado.												

SELECT prodCodigo,prodDescricao,prodValorVenda 
FROM tbProdutos 
ORDER BY prodValorVenda ASC







--5 - Escolha 3 clientes e mostre todas as compras feitas por eles ordenado e formatado.
	
 
 SELECT venCodigo,cliNome 
FROM tbVendas,tbClientes
WHERE (cliNome like 'antonio')or(cliNome like 'ana')or(cliNome like 'Amanda')
ORDER BY cliNome ASC





--6 - Escolha 3 funcionários e mostre todas as vendas feitas por eles ordenado e formatado.


SELECT venCodigo, funNome
FROM tbVendas,tbFuncionarios
WHERE (funNome like 'Pedro')or( funNome like 'Lucas')or(funNome like 'Ruan')
ORDER BY funNome ASC









--7 - Escolha 2 vendas e mostre todos os produtos de cada venda ordenado e formatado.


SELECT prodCodigo,venCodigo
FROM tbVendas,tbProdutos
WHERE (venCodigo like '1')or (venCodigo like '3')
ORDER BY prodCodigo ASC








 --//8 - Mostre todos os fornecedores estrangeiros.		
 
	SELECT * FROM tb_Fornecedores WHERE forLO <> 'BR'
	
	

	--9 - Mostre todos os Clientes que compraram mais de 3 vezes.

SELECT cliNome
FROM tbClientes,tbVendas
WHERE venCodigo > 3 




--10 - Mostre os todos os clientes onde a primeira letra do nome é B e a terceira letra é A da cidade de São Paulo ou do Rio de Janeiro.

SELECT cidSigla,cliNome
FROM tbClientes,tbCidades
WHERE (cidSigla = 'SP') or (cidSigla = 'RJ') and (cliNome like 'b%') and (cliNome like '__A%') 

*/