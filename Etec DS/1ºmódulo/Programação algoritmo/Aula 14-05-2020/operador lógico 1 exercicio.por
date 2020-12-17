programa
{
	
	funcao inicio()
	{
		inteiro data,ano,codigo,idade,tempo
		escreva("Informe sua data de nascimento: ")
		leia(data)
		limpa()
		escreva("Informe o ano que você ingressou na empresa: ")
		leia(ano)
		limpa()
		escreva("Informe o seu código de empregado: ")
		leia(codigo)
		idade = 2020 - data 
		tempo = 2020 - ano
		se(tempo>=30 e idade>=65){
			escreva(codigo," Requer aposentadoria, você tem ",tempo," anos de trabalho e tem ",idade," anos de idade")
		}senao{
			escreva(codigo," Não requer aposentadoria você tem ",tempo," anos de trabalho e tem ",idade," anos de idade")
		}
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 328; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */