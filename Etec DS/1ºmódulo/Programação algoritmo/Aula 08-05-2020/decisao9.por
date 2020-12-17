programa
{
	
	funcao inicio()
	{
		cadeia nome
		real saba,tv,comi,sato,comisa
		escreva("informe o seu nome ")
		leia(nome)
		limpa()
		escreva("informe o seu salario ")
		leia(saba)
		limpa()
		escreva("informe o seu total de vendas ")
		leia(tv)
		se(tv>5000.00){
			comi = 0.10
			comisa = saba*comi
			sato = saba+comisa
			escreva(nome," você recebeu R$ ",comisa,"de comissão \n E se salário total é de R$ ",sato)
		}senao se(tv>3000.00 e tv<=5000.00){
			comi = 0.05
			comisa = saba*comi
			sato = saba+comisa
			escreva(nome," você recebeu R$ ",comisa," de comissão \n E se salário total é de R$ ",sato)
		}senao se(tv>1000.00 e tv<=3000.00){
			comi = 0.02
			comisa = saba*comi
			sato = saba+comisa
			escreva(nome," você recebeu R$ ",comisa," de comissão \n E se salário total é de R$ ",sato)
		}senao se(tv<=1000.00){
			comi = 0
			comisa = saba*comi
			sato = saba+comisa
			escreva(nome," você recebeu R$ ",comisa,"de comissão \n E se salário total é de R$ ",sato)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 944; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */