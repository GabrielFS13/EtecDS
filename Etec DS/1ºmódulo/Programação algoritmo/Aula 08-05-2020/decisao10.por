programa
{
	
	funcao inicio()
	{
		real nota1,nota2,nota3,total//delaração de variaveis
		escreva("Digite a 1°Nota ")//vai pede para o usuario informar um numero
		leia(nota1)//vai ler o numero que o usuario escreveu e guardar na variavel "nota1"
		escreva("Digite a 2°Nota ")//vai pede para o usuario informar um numero
		leia(nota2)//vai ler o numero que o usuario escreveu e guardar na variavel "nota2"
		escreva("Digite a 3°Nota ")//vai pede para o usuario informar um numero
		leia(nota3)//vai ler o numero que o usuario escreveu e guardar na variavel "nota3"
		total = ((nota1*2)+(nota2*3)+(nota3*5))/10//vai fazer o calculo das notas para saber se o aluno foi aprovado ou reprovado
		se (total>=5){//vai ver se o resultado "total" atende aos requisitos do "se"
			escreva("Aluno aprovado")//vai informar ao usuario que o aluno foi aprovado
		}senao{//caso o requsito não tenha sido atendido
			escreva("Aluno reprovado ")//vai informar ao usuario que o aluno foi reprovado
		}
	}
}//Aluno gabriel falcão gamonal carvalho
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 988; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */