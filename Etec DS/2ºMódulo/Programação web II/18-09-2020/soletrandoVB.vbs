dim palavras(20), sort, n, res, wins, loses,jump
dim audio

wins = 0
loses = 0
jump = 3
call carregar_fala
sub carregar_fala()
set audio=createobject("SAPI.SPVOICE")
audio.volume=100
audio.rate=1
call inicio
end sub

sub inicio()
palavras(1)="Panela"
palavras(2)="Rato"
palavras(3)="Churrasco"
palavras(4)="Soletrando"
palavras(5)="Furadeira"
palavras(6)="Posto"
palavras(7)="Jogo"
palavras(8)="Desenvolvimento"
palavras(9)="Vida"
palavras(10)="Hoje"
palavras(11)="Jacaré"
palavras(12)="Voar"
palavras(13)="Cemitério"
palavras(14)="Filme"
palavras(15)="Esquadrão"
palavras(16)="Roupa"
palavras(17)="Destino"
palavras(18)="Cair"
palavras(19)="Fotografia"
palavras(20)="Programa"

randomize(second(time))
sort=int(rnd * 20) + 1
call resposta
end sub

sub resposta()
audio.speak("Digite a palavra: " & palavras(sort))
res=InputBox("Digite a palavra: " + vbnewline &_
"[O]Ouvir novamente"+ vbnewline &_
"[P]Pular palavra ( "&jump&" ) restantes","SOLETRANDO")
if jump=0 then
msgbox("VOCê NÃO PODE MAIS PULAR!")
call semjump
end if
if res="p" or res="P" then
jump = jump-1
call inicio
end if
if res=palavras(sort) then
audio.speak("Isso!, você acertou.")
wins = wins+1
call novamente
elseif res="O" or res="o" then
call semNovamente
else
audio.speak("Essa não,você errou, você é surdo por acaso?.")
loses = loses+1
call novamente
end if
end sub

sub novamente()
jump = 3
audio.speak("O placar atual é: " + vbNewLine &_
"Número de vitórias" & wins &"" + vbNewLine &_
"Número de derrotas" & loses &"")
msgbox("===========================" + vbnewline &_
" 	   PLACAR DO JOGO " + vbnewline &_
"===========================" + vbnewline &_
"Número de vitórias: "& wins &" " + vbnewline &_
"Número de derrotas: "& loses &""),vbinformation+vbokonly,"PLACAR"
res=msgbox("Deseja jogar novamente?",vbquestion+vbyesno,"OPÇÃO")
if res=vbyes then
call inicio
else
audio.speak ("Obrigado por jogar, foi muito divertido, até logo.")
wscript.quit
end if
end sub
sub semjump()
audio.speak("Digite a palavra: " & palavras(sort))
res=InputBox("Digite a palavra: " + vbnewline &_
"[O]Ouvir novamente","SOLETRANDO")
end sub
sub semNovamente()
audio.speak("Digite a palavra: " & palavras(sort))
res=InputBox("Digite a palavra: " + vbnewline &_
"[P]Pular palavra( "&jump&" )restantes","SOLETRANDO")
end sub