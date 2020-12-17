programa
{
	
	funcao inicio()
	{
		cadeia pais
		inteiro idade
		escreva("Country/País:(BRA, USA, OU POR)\n")
		leia(pais)
		limpa()
		escreva("Idade: ")
		leia(idade)
		limpa()
		se(pais == "BRA" e idade>=18){
			escreva("Permitido")
		}senao se (pais == "USA" e idade >=21){
			escreva("Allowed")
		}senao se (pais == "POR"){
			escreva("permitido")
		}senao{
			escreva("Não permitido/Not Allowed")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 399; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */