programa
{
	
	funcao inicio()
	{
		inteiro sele,a,b
		escreva("Informe a operação desejada \n (1)Soma(+)\t (2) Subtração(-)\n (3)Multiplicação(X,*)\t (4)Divisão(:,/)\n ")
		leia(sele)
		escreva("Por favor informe o valor A:\n")
		leia(a)
		escreva("Por favor informe o valor B:\n")
		leia(b)
		limpa()
		escolha(sele){
				caso 1:soma(a,b)	
				pare
				caso 2:sub(a,b)
				pare
				caso 3: multi(a,b)
				pare
				caso 4:divi(a,b)
				pare
				caso contrario:escreva("Escolha uma operação válida")
		}
	}
	funcao soma(inteiro a,inteiro b){
		escreva("A soma do valor A com o B é de: ", a+b)
	}
	funcao sub(inteiro a,inteiro b){
		escreva("A subtração do A com o B é de: ", a-b)
	}
	funcao multi(inteiro a,inteiro b){
		escreva("A multiplicação do valor A com o B é de: ", a*b)
	}
	funcao divi(inteiro a,inteiro b){
		escreva("A divisão do valor A com o B é de: ", a/b)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 301; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */