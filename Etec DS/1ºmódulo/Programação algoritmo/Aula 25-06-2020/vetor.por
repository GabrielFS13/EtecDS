programa
{
	
	funcao inicio()
	{
		inteiro vetor[5]

		vetor[0] = 20
		vetor[1] = 9
		vetor[2] = 3
		vetor[3] = 10
		vetor[4] = 1
	//apresentar vetor
		para( inteiro i=0;i<5;i++){
			se (i==4){
				escreva(vetor[i])				
			}senao{					/*corrigir aquele hífen que sobra no final*/	
				escreva(vetor[i],"-")
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 318; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {vetor, 6, 10, 5};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */