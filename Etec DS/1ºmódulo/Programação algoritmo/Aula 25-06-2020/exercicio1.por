programa
{
	
	funcao inicio()
	{
		inteiro vetor[10]
		inteiro res = 0

	para(inteiro i = 0; i<=9; i++){
        escreva ("digite 10 numeros para o vetor "+i+":")
        leia(vetor[i])
        limpa()
	}
	para(inteiro i=0;i<10;i++){

		se(vetor[i] % 2 == 0){

		res = res + vetor[i]
			}
		}	
		escreva(res)		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 153; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */