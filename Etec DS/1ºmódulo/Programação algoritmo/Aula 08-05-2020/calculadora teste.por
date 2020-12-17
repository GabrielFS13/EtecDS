programa
{
	
	funcao inicio()
	{
		cadeia op
		real n1,n2,res
		escreva ("Digite +,-,* ou / para executar uma operação \n ")
		leia(op)
		limpa()
		escreva(" Digite um valor: \n")
		leia(n1)
		limpa()
		escreva(" Digite outro valor: \n")
		leia(n2)
		limpa()
		se (op == "+"){
			res = n1+n2
		}senao se(op == "-"){
			res = n1-n2
		}senao se(op == "*"){
			res = n1*n2
			}
		senao se(op == "/"){
			res = n1/n2
		}senao{
			res = 0.0 
			escreva("Impossível realizar operação \n ")			
		}
		escreva("Resultado \n", n1, "",op,"",n2,"= ", res)	
		}
	}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 552; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */