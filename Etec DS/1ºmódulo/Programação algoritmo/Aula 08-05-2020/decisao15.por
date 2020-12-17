programa
{
	
	funcao inicio()
	{
	cadeia n,  tipo               
        inteiro nd
        real ci,td, sb, ts,total
        escreva("digite seu nome:\n")
        leia(n)
        limpa()
        escreva("tipo de quarto:\n")
        leia(tipo)
        limpa()
        escreva("numero de diarias:\n")
        leia(nd)
        limpa()
        escreva("consumo interno:\n")
        leia(ci)
        limpa()
        se (tipo==tipo a){
        td=(nd*150.00)
        sb=(td+ci)
        ts=(sb*10)/100
        total=(sb+ts)
        escreva("nome do hospede:\n",n ,"\ntipo de apartamento:\n",tipo, "\n numero de diarias\n", nd, "\n valor da diaria:\n 150.00R$")
        escreva("\n valor total das diarias:\n", td, "R$\n,valor do consumo interno:\n", ci, "\n Subtotal\n",sb ,"\n taxa de serviços\n", ts)  
        escreva("\n total geral ", total".")
        }senao se(tipo==tipo b){
        td=(nd*100.00)
        sb=(td+ci)
        ts=(sb*10)/100
        total=(sb+ts)
        escreva("nome do hospede:\n",n ,"\ntipo de apartamento:\n",tipo, "\n numero de diarias\n", nd, "\n valor da diaria:\n 150.00R$")
        escreva("\n valor total das diarias:\n", td, "R$\n,valor do consumo interno:\n", ci, "\n Subtotal\n",sb ,"\n taxa de serviços\n", ts)  
        escreva("\n total geral ", total".")   
        }senao se(tipo==tipo c){
        td=(nd*75.00)
        sb=(td+ci)
        ts=(sb*10)/100
        total=(sb+ts)
        escreva("nome do hospede:\n",n ,"\ntipo de apartamento:\n",tipo, "\n numero de diarias\n", nd, "\n valor da diaria:\n 150.00R$")
        escreva("\n valor total das diarias:\n", td, "R$\n,valor do consumo interno:\n", ci, "\n Subtotal\n",sb ,"\n taxa de serviços\n", ts)  
        escreva("\n total geral ", total".")
        }senao se (tipo==tipo d){
        td=(nd*50.00)
        sb=(td+ci)
        ts=(sb*10)/100
        total=(sb+ts)
        escreva("nome do hospede:\n",n ,"\ntipo de apartamento:\n",tipo, "\n numero de diarias\n", nd, "\n valor da diaria:\n 150.00R$")
        escreva("\n valor total das diarias:\n", td, "R$\n,valor do consumo interno:\n", ci, "\n Subtotal\n",sb ,"\n taxa de serviços\n", ts)  
        escreva("\n total geral ", total".")
       }   
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 2194; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */