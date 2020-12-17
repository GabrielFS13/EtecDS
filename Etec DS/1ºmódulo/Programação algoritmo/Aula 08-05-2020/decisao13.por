programa
{
	
	funcao inicio()
	{
		real massa,peso,altura
		escreva("informe o seu peso ")
		leia(peso)
		escreva("informe a sua altura ")
		leia(altura)
		massa = peso/(altura*altura)
		se(massa<26){
			escreva("Você está no peso ideal")
		}senao se(massa>26 e massa<30){
			escreva("Você está no nível de obesidade")
		}senao se(massa>30){
			escreva("Você está em obesidade mórbida ")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 184; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */