programa
{
	
	funcao inicio()
	{
		inteiro sinal,a,b
		escreva("Por favor informe o valor A:\n")
		leia(a)
		escreva("Por favor informe o valor B:\n")
		leia(b)
		escreva("Selecione o tipo de operação que você deseja:\n (1)Soma(+)\t (2) Subtração(-)\n (3)Multiplicação(X,*)\t (4)Divisão(:,/)\n ")
		leia(sinal)
		limpa()
		escolha(sinal){
			caso 1: escreva("A soma dos valor é de: ",a+b)
			pare
			caso 2: escreva("A subtração dos valores é de: ",a-b)
			pare
			caso 3: escreva("A multiplicação dos valores é de:", a*b)
			pare
			caso 4: escreva("A divisão dos valores é de: ",a/b)
			pare
			caso contrario : escreva("Impossível realizar a operação desejada, por favor, use somente as operações de 1 a 4")
		}

	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 708; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */