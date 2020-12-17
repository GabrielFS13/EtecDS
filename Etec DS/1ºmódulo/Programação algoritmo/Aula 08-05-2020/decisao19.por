programa
{   /*Faça um algoritmo que calcule o custo de um frete, sabendo que:
    * A quilometragem lida deve ser múltiplo de 100;
    * O custo do frete é de R$ 500,0 se for de até 200 quilômetros;
    * A cada 100 quilômetros a mais no percurso deve ser adicionado R$ 150,00 ao frete;
    * Se a quilometragem do frete for maior que 2000 quilômetros, deverá ser adicionado R$ 0,50 por quilômetro como taxa adicional de seguro.
    No final mostrar o valor total do frete.
    */
   
    funcao inicio()
    {    real b
        inteiro a
        escreva("digite frete\n")//Abre o cursor para ser inserido o a QUILOMETRAGEM
        leia(a)//ira ler o frete que é representao pelo variavel a
        limpa()//ira limpar VISUALMENTE os informações,apenas ira limpar a tela,as informações ainda estaram armazenadas
        se (a<=200){// se a quilometragem é igual ou MENOR que 200 sera de 500R$
            escreva("seu frete é de 500R$")
        }senao se(a>200 e a<=2000){//se A(quilometagrem),for maior que 200 e menor ou igaul a 2000
            b=(((a-200)*1.5)+500)//tera um acrescimo ,subtraindo 200 da QUilometragem temos os KM a mais e multiplicando por 1,5 teremos
            escreva("seu frete é:",b)//o valor adicional que sera somado com os 500 R$
        }senao se(a>2000){//se a KM for maior que 2000 teremos
          b=((((a-200)*0.5))+500)//descobrindo o exesso,multiplicando por 0.5 teremos os valores adicionados por ser superior a 2000    teremos a taxa de segurança
          escreva("seu frete é:",b)
        }
       
       
    }
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1557; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */