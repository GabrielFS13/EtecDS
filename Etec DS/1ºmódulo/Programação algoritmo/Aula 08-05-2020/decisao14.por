programa
{
	
	funcao inicio()
	{
		cadeia nome
		real saat,sare,porcent,saref
		escreva("Informe o seu nome ")
		leia(nome)
		escreva("Informe o seu salário atual ")
		leia(saat)
		se(saat<=1000.00){
			porcent=0.30
			sare = saat*porcent
			saref = sare+saat
			escreva(nome," Seu salário atual é R$ ",saat," e foi reajustado para R$ ",saref)
		}senao se(saat<5000.00){
			porcent=0.15
			sare = saat*porcent
			saref = sare+saat
			escreva(nome," Seu salário atual é R$ ",saat," e foi reajustado para R$ ",saref)
		}senao se(saat>5000.00){
			porcent=0.075
			sare = saat*porcent
			saref = sare+saat
			escreva(nome," Seu salário atual é R$ ",saat," e foi reajustado para R$ ",saref)
		}
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