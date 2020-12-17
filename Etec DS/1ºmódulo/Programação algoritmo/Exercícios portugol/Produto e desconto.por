programa
{
	
	funcao inicio()
	{
		real vp, desc, to, val , dec , vl_desc
		escreva(" Informe o valor do produto ")
		leia (vp)
		escreva (" Digite o percentual de desconto")
		leia (desc)
		to = vp*(desc/100)
		vl_desc = vp-to
	escreva (" O valor do desconto é " , to)
	escreva (" \n O valor do produto é " , vp)
	escreva (" \n O valor do produto com desconto é ",vl_desc)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 285; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */