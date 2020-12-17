programa
{
	
	funcao inicio()
	{
//Elabore um ALGORITMO que calcule o que deve ser pago por um produto,
// considerando o preço de etiqueta e a escolha da condição de pagamento.
// Utilize os códigos da tabela a seguir para ler qual a condição de 
//pagamento escolhida e efetuar o cálculo adequado.
//      Código	     Condição de pagamento
//		1		A vista em dinheiro ou cheque, recebe 10% de desconto
//		2		A vista no cartão de crédito, recebe 5% de desconto
//		3		Em duas vezes, preço normal de etiqueta sem juros
//		4		Em três vezes, preço normal de etiqueta mais juros 
//				de 10%
		real produto, valor = 0.0
		inteiro opc
		escreva("Digite o valor do produto:\n")
		leia (produto)
		escreva("Digite a forma de pagamento: \n(1) A vista em denheiro ou cheque\t(2)A vista em cartão\n(3) Em duaz vezes\t (4) em tres vezes\n")
		leia(opc)
		escolha (opc){
			caso 1:
			valor = (produto -(produto *0.10))
			escreva("O produto custará 10% mais em conta R$ ", valor)
			caso 2:
			valor = (produto -(produto *0.05))
			escreva("O produto custará 5% mais em conta R$ ", valor)
			caso 3:
			valor = (produto)
			escreva("O produto custará o preço normal de R$ ", valor)
			caso 4:
			valor = (produto +(produto *0.10))
			escreva("O produto custará 10% mais em caro R$ ", valor)
			caso contrario:
  				escreva("Digite uma forma de pagamento válida")
		}
	}		
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1353; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */