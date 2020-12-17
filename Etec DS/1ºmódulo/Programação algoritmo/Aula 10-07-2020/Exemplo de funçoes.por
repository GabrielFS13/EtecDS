programa
{
	
	funcao inicio()
	{
		cadeia nomes[3] = {"Amanda", "Renato", "Agatha"}
		real notas[3][4] = {{10.0,9.0,8.0,9.0},{1.0,5.0,2.0,5.0},{7.0,9.0,8.0,10.0}}
		real medias[3] // cada posição se refere a um aluno
		media(notas,medias)
		inteiro aluno
		cadeia apr
		escreva("Digite o numero do aluno: ")
		leia(aluno)
		limpa()
		se(aprovado(medias[aluno])){
			apr ="Aprovado"
		}senao{
			apr = "Reprovado"
		}
		geraRelatorio(nomes[aluno], notas[aluno][0], notas[aluno][1],notas[aluno][2],notas[aluno][3],medias[aluno], apr)
	}
	funcao logico aprovado(real notas){
		se(notas >= 6){
			retorne verdadeiro
		}senao{
			retorne falso
		}
	}
	funcao media(real notas[][], real &medias[]){
		// calculos das médias
		para (inteiro l=0;l<3;l++){ // vai percorrer toda a linha da matriz
			real soma = 0.0
			para( inteiro c =0;c<4; c++){
				soma = soma + notas [l][c] //vai somar cada nota
			}
			medias[l] = soma/4
		}
	}

	funcao escreveLinha(logico forte){
		se (forte) {
			escreva("*====================*","\n")
		}senao{
			escreva("*--------------------*","\n")
		}
	}

	funcao geraRelatorio(cadeia nome, real b1,real b2, real b3, real b4, real avr,cadeia apr)
	{
	escreveLinha(verdadeiro)
	escreva("*Aluno: ",+nome,"       *\n")
	escreveLinha(falso)
	escreva("*    1B   ",+b1,"       *\n")
	escreva("*    2B   ",+b2,"        *\n")
	escreva("*    3B   ",+b3,"        *\n")
	escreva("*    4B   ",+b4,"        *\n")
	escreveLinha(falso)
	escreva("*Média:  ",+avr,"         *\n")
	escreva("*Situação = " +apr," *\n")
	escreveLinha(verdadeiro)
}
	
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1081; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */