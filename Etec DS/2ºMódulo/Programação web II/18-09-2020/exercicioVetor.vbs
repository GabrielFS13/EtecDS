dim nome(5),n'declarar vetor

call carregarNomes
sub carregarNomes()
nome(1)="Moquidésia"
nome(2)="Joana"
nome(3)="Ana"
nome(4)="Pedro"
nome(5)="João"
for n=1 to 5 step 1 'laço de repetição'
    msgbox(nome(n))
    next
msgbox("Fim do laço"),vbinformation+vbokonly,"AVISO"
end sub