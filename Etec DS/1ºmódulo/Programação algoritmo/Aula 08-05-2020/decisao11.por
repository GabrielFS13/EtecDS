programa
{
	
	funcao inicio()
	{
		real a, b,c,d, i, t
		escreva("informe q quantidade de horas trabalhadas\n ")
		leia(a)
		b=50*15
		c=a-50
		d=(a-50)*20
		t=d+b
		se (d>800){
			i=(800*8)/100
			escreva("pagamento por horas extras ",d,"R$ impostos descontados \n",i, "R$,salário final \n",t,"R$")
		}senao{
			escreva("pagamento por horas extras ",d,"R$ impostos descontados \n R$,salário final \n",t,"R$")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 269; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */