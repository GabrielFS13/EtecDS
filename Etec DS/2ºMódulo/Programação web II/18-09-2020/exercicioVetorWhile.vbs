dim nome(5),n'declarar vetor

call carregarNomes
sub carregarNomes()
nome(1)="Moquidésia"
nome(2)="Joana"
nome(3)="Ana"
nome(4)="Pedro"
nome(5)="João"
n=1
do while n<=5
    msgbox(nome(n))
    n=n+1
loop
msgbox("Fim do laço"),vbinformation+vbokonly,"AVISO"
end sub