programa
{
	
	funcao inicio()
	{
		//inteiro vet [4]={1,2,3,4}
		inteiro notas[4][4] = {{1,2,3,4},{2,3,4,5},{3,4,5,6},{4,5,6,7}}
		para(inteiro l=0;l<4;l++){//percorre a LINHA
			para(inteiro c=0;c<4;c++){//percore COLUNA///////mostrar a matriz utiliza-se o para praticamente sempre
			escreva(notas[l][c],",")
		}
		escreva("\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 179; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {notas, 7, 10, 5};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */