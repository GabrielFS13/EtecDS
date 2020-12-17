programa
{
   
    funcao inicio()
    {
        real a[12]={12.8, 25.7, 63.0, 98.52, 65.4, 123.2, 89.25, 96.5, 96.2, 78.21, 54.02, 34.12 }, b=0.0, c=0.0
        inteiro i
        para(i=0; i<12; i++){// se o vetor I for igaul a 0(1° posição) e for até  3( 3 posição°)
        b=(b+a[i])//b= 0´para inicializar a variavel
        c=(b/12)
        }
         escreva("soma=\t", b"")
         escreva("\nmedia=\t", c)//fora do para,pois se for dentro irá funcionar de forma bizarra
    }  
   
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 493; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */