programa
{
   
    funcao inicio()
    {
        inteiro h
        real hex, trab,t ,dg,st
        escreva("digite suas horas trabalhadas\n")
        leia(h)
        limpa()       
        hex=((h-40)*37.50)
        trab=(40.*25.00)
        t=(hex+trab)
        se (t>1000.00){
        dg=(t*12)/100
        st=(t-dg)
        escreva("salario líquido:\n",trab ,"R$", "\n acrescimo de:\n",hex ,"R$", "\n impostos\n -",dg , "R$", "\nsalário total\n", st, "R$" )   
        }senao{
        escreva("salario líquido:\n",trab ,"R$", "\n acrescimo de:\n 00.00 R$", "\n impostos\n 00.00 R$", "\nsalário total:\n",trab, "R$"  )
        }
    }
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 629; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */