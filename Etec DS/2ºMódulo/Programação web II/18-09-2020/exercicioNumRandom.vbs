dim nome(5),n,sorteio

call carregarNomes
sub carregarNomes()
nome(1)="Moquidésia"
nome(2)="Joana"
nome(3)="Ana"
nome(4)="Pedro"
nome(5)="João"
n=1
do while n<=5
    'numeros randomicos
    randomize(second(time))'Deixará o sorteio dinâmico, basenando-se pelos segundos da hora do SO
    sorteio=int(rnd*5)+1
    msgbox(nome(sorteio))
    n=n+1
loop
msgbox("Fim do laço"),vbinformation+vbokonly,"AVISO"
end sub