programa
{
	
	funcao inicio()
	{
		real cod, pkw,qkw,tp//declaração de variaveis
		escreva("Informe o seu código de consumidor ")//pede para informar o codigo de consumidor
		leia(cod)//vai ler e amarzenar na variavel "cod"
		escreva("Informe a quantidade de KW consumida ")//pede para informar a quantidade de KW consumida
		leia(qkw)//vai ler e amarzenar na variavel "qtw"
		limpa()//vai limpar o console (ou seja vai apagar os "escrevas" mas n as variaveis)
		tp = qkw*0.52//vai fazer o calculo do preço do consumo de KW...(0.52 é o preço do KW) 
		se(tp<=11.20){//vai entrar na condição para saber em qual situação a variavel "tp" se encaixa
			escreva("O valor total é R$ 11,20 ")//mostrou para o usuario a quantidade a se pagar em R$
		}senao{//caso "tp" n tenha sido atendida na primeira opção vem para essa a seguir:
			escreva(cod,"\n Você consumiu um total de R$ ",tp," em energia")//informou a variavel "cod" e a variaavel "tp" para o usuario
		}
	}//Aluno gabriel falcão gamonal carvalho
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 80; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */