programa
{
	
	funcao inicio()
	{
		inteiro a, b, c
	     escreva("digite o valor A "D)
	     leia(a)
	     escreva("digite o valor B ")
	     leia(b)
	     escreva("digite o valor C ")
	     leia(c)
	    se ((a<b+c) e (b<c+a) e (c<b+a)e (a==b) e (b==c)){
	    	escreva("triangulo equilatero") 
	    }senao se(a==b e b==c e a==c){
	    	escreva("Triangulo esoceles")
	    }senao  {
	    	escreva("triangulo escaleno")
	    }
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 85; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */