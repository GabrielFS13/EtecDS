programa
{
	
	funcao inicio()
	{
		inteiro pedido, quantidade
		escreva("Qual o seu pedido? \n (1) Hamburger \t (2) Cheeseburguer \n (3) Misto quente \t (4) Americano \n (5) Queijo prato \n ")
		leia(pedido)
		escreva("Informe a quantidade: \n")
		leia(quantidade)
		limpa()
		escolha(pedido){
			caso 1:H(quantidade)
			pare
			caso 2:C(quantidade)
			pare
			caso 3:M(quantidade)
			pare
			caso 4:A(quantidade)
			pare
			caso 5:Q(quantidade)
			pare
			caso contrario: escreva(" Escolha um pedido válido ")
		}
	}
	funcao H(inteiro quantidade){
		escreva("O total a se pagar é de: ", 3.00*quantidade)
	}
	funcao C(inteiro quantidade){
		escreva("O total a se pagar é de: ", 3.80*quantidade)
	}
	funcao M(inteiro quantidade){
		escreva("O total a se pagar é de: ", 2.50*quantidade)
	}
	funcao A(inteiro quantidade){
		escreva("O total a se pagar é de: ", 4.20*quantidade)
	}funcao Q(inteiro quantidade){
		escreva("O total a se pagar é de: ", 1.80*quantidade)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 946; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */