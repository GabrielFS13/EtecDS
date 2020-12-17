programa
{
   
    funcao inicio()
    {
        inteiro h,t
        real m,tu,ti
        escreva("digte o numero de homens\n")
        leia(h)
        limpa()
        escreva("digite o tamanho do muro\n")
        leia(m)
        limpa()
        escreva("digite o tipo de tijolos:1 para baianos e 2 para normais\n ")
        leia(t)
        limpa()
        se (t==1){
        ti=(m/h)
        tu=(m*50)
        escreva("tempo gasto:\n", ti,"H", "\ntijolos a serem gastos\n",tu )   
        }senao se(t==2){
        ti=(m/h)
        tu=(m*150)
        escreva("tempo gasto:\n", ti,"H", "\ntijolos a serem gastos\n",tu )   
        }
    }
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 0; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */