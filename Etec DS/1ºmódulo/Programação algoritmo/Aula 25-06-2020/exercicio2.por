programa
{
	
	funcao inicio()
	{
		inteiro x = 0, i = 0, vetor[20], n = 0

		escreva("Determine um valor para N: ")leia(n)
		limpa()
		para(i = 0; i < 20; i++){
			escreva("Digite o valor do índice ", i, " do vetor: ")leia(vetor[i])
			}
		limpa()
		escreva("Índices dos elementos maiores que N: \n")
		para(i = 0; i < 20; i++){
			se(vetor[i] > n){
				escreva("Índice : ",i," Valor: ",vetor[i],"\n")
			}
		}
		escreva("\nÍndices dos elementos iguais a N: \n")
		para(i = 0; i < 20; i++){
			se(vetor[i] == n){
				escreva("Índice : ",i," Valor: ",n,"\n")
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 401; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */