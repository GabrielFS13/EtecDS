programa
{
	
	funcao inicio()
	{
		cadeia nomes[3] = {"Amanda", "Renato", "Agatha"}
		real notas[3][4] = {{10.0,9.0,8.0,9.0},{1.0,5.0,2.0,5.0},{7.0,9.0,8.0,10.0}}
		real medias[3] // cada posição se refere a um aluno
		// calculos das médias
		para (inteiro l=0;l<3;l++){ // vai percorrer toda a linha da matriz
			real soma = 0.0
			para( inteiro c =0;c<4; c++){
				soma = soma + notas [l][c] //vai somar cada nota
			}
			medias[l] = soma/4
		}
		inteiro aluno
		cadeia apr
		escreva("Digite o numero do aluno: ")
		leia(aluno)
		limpa()
		se(medias[aluno]>=6){
			apr ="Aprovado"
		}senao{
			apr = "Reprovado"
		}
	escreva("*====================*","\n")
	escreva("*Aluno: ",+nomes[aluno],"       *\n")
	escreva("*--------------------*","\n")
	escreva("*    1B   ",+notas[aluno][0],"       *\n")
	escreva("*    2B   ",+notas[aluno][1],"        *\n")
	escreva("*    3B   ",+notas[aluno][2],"        *\n")
	escreva("*    4B   ",+notas[aluno][3],"        *\n")
	escreva("*--------------------*","\n")
	escreva("*Média:  ",+medias[aluno],"         *\n")
	escreva("*Situação = " +apr," *\n")
	escreva("*====================*")
	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 614; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */