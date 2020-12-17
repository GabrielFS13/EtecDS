programa
{
	inclua biblioteca Texto
	
	funcao inicio()
	{
		cadeia in
		inteiro n, f= 0,m=0,x=0
		caracter a
		escreva("Digite a entrada de dados: ")
		leia(in)
		limpa()
		in = Texto.caixa_alta(in)
		n = Texto.numero_caracteres(in)
		para(inteiro i=0;i<n;i++){
			a = Texto.obter_caracter(in, i)
			se(a == 'F'){
				f++
			}senao se(a=='M'){
				m++
			}senao{
				x++
			}
			
		}
		escreva("São ",f," mulheres e ",m," homens ",x," Não se informaram o genero.")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 429; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {in, 7, 9, 2}-{f, 8, 13, 1}-{m, 8, 18, 1}-{a, 9, 11, 1};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */