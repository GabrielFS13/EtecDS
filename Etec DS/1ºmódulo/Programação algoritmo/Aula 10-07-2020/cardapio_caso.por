programa
{
	
	funcao inicio()
	{
		inteiro quantidade,codigo

		escreva("Infome o código do produto: \n (1) Hamburger \t (2) Cheeseburguer \n (3) Misto quente \t (4) Americano \n (5) Queijo prato \n")
		leia(codigo)
		escreva("Por favor informe a quantidade do produto: ")
		leia(quantidade)

		escolha(codigo){
			
		caso 1: escreva("O total a se pagar é de: ",3.00*quantidade)
		pare
		caso 2: escreva("O total a se pagar é de: ",3.80*quantidade)
		pare
		caso 3: escreva("O total a se pagar é de: ",2.50*quantidade)
		pare
		caso 4: escreva("O total a se pagar é de: ",4.20*quantidade)
		pare
		caso 5: escreva("O total a se pagar é de: ",1.80*quantidade)
		pare
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 665; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */