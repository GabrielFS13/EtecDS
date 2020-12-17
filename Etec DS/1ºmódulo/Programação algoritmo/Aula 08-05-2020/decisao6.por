programa
{
	
	funcao inicio()
	{
		cadeia g
		real a, res
		escreva("Informe sua altura ")
		leia(a)
		escreva("Se você for homem digite H,caso seja mulher digite M ")
		leia(g)
		limpa()
		se (g == "H"){
			res = 72.7*a
			escreva("seu peso ideial é ",res)
		}senao{
			res = 62.1*a
			escreva("seu peso ideial é ",res)
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 320; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */