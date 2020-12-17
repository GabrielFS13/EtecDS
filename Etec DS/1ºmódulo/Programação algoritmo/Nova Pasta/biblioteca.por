programa
{
	inclua biblioteca Util --> ut//apelidar

	funcao inicio()
	{
		inteiro b,a
		b = ut.sorteia(1, 100)//Util.sorteia(minimo,maximo) tem que definir qual é o número minimo e o maximo
		escreva(b)
		ut.aguarde(2000)//util.aguarde esperar mum tempinho informar em MS
		a=ut.sorteia(2, 500)
		escreva("\n",a)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 272; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */