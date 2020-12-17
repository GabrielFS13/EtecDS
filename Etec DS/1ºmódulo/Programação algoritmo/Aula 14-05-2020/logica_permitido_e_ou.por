programa
{
	
	funcao inicio()
	{
		cadeia pais
		inteiro idade
		logico permitido
		escreva("Country/País:(BRA, USA, OU POR)\n")
		leia(pais)
		limpa()
		se (pais == "BRA" ou pais == "POR"){
			escreva("Idade: ")
		}senao {
			escreva("Age: ")
		}
		leia(idade)
		limpa()
		se(pais == "BRA" e idade>=18){
			permitido = verdadeiro
		}senao se (pais == "USA" e idade >=21){
			permitido = verdadeiro
		}senao se (pais == "POR"){
			permitido = verdadeiro
		}senao{
			permitido = falso 
		}
		se ( permitido e (pais =="BRA" ou pais == "POR")){
			escreva("Permitido")
		}senao se (permitido e pais == "USA"){
			escreva("Allowed")
		}senao se (nao permitido e (pais =="BRA" ou pais == "POR")){
			escreva("Não permitido")
		}senao se (nao permitido e pais == "USA"){
			escreva("Not Allowed")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 247; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */