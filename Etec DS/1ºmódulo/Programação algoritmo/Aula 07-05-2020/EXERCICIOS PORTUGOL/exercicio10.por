programa {
funcao inicio() 
{ 
	real lat, gr, carne, a1, a2, a3, a4, c1, c2, c3, c4, tot
escreva("Digite a quantidade em quilos a ser transportada de laticinio: ") 
leia(lat) 
escreva("Digite a quantidade em quilos a ser transportada de Grãos: ") 
leia(gr) 
escreva("Digite a quantidade em quilos a ser transportada de carne: ") 
leia(carne) 
a1 = (lat*0.12) +(gr*0.43) + (carne*0.29) a2 = (lat*0.33) +(gr*0.09) + (carne*0.41) a3 = (lat*0.28) +(gr*0.31) + (carne*0.16) a4 = (lat*0.27) +(gr*0.17) + (carne*0.14) c1=a1*0.20 c2=a2*0.17 c3=a3*0.23 c4=a4*0.26 tot = c1+c2+c3+c4
escreva("A quantidade em quilos a ser transportada de laticinio é : ", lat)
escreva(" , e a quantidade em quilos a ser transportada de Grãos é: ", gr)
escreva(" e a quantidade em quilos a ser transportada de carne é: ", carne) 
escreva ("\n O armazem 1 terá de custo de transporte R$ ", c1, " , o armazem 2 terá de custo de transporte R$ ", c2) 
escreva (", \n o armazem 3 terá de custo de transporte R$ ", c3, " , o armazem 4 terá de custo de transporte R$ ", c4) 
escreva("\n Total do custo é de: R$ ", tot)
}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1039; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */