dim n1,n2,n3,n4,n5,n6,n7,n8,n9,res1,res2,res3,res4,res5,res6,res7,res8,res9,acertos,erros,audio,resp
erros = 0
acertos = 0
call FALA
sub FALA()
set audio=createobject("SAPI.SPVOICE")
audio.volume=100
audio.rate=1
end sub
call inicio
sub inicio()

randomize(second(time))

n1 = int(rnd*100)+1
n2 = int(rnd*100)+1
n3 = int(rnd*100)+1
n4 = int(rnd*100)+1
n5 = int(rnd*100)+1
n6 = int(rnd*100)+1
n7 = int(rnd*100)+1
n8 = int(rnd*100)+1
n9 = int(rnd*100)+1
call etapa1
end sub

sub etapa1()
    audio.speak(n1&",e "&n2)
res1 = cint(inputbox("Digite o valor que você ouviu!"+vbnewline &_
                     "PS:Digite o número que ouviu e depois o outro!","Memorizando Etapa 1"))
res2 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 1"))
if res1=n1 and res2 = n2 then
call etapa2
acertos = acertos + 1
else
msgbox("Sequência incorreta!!! Total de acertos: "&acertos&""+vbnewline &_
       "Total de erros: "&erros)
erros = erros + 1
call denovo
end if
end sub

sub etapa2()
audio.speak(n1&" "&n2&"e"&n3)
res1 = cint(inputbox("Digite o valor que você ouviu!"+vbnewline &_
                     "PS:Digite o número que ouviu e depois o outro!","Memorizando Etapa 2"))
res2 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 2"))
res3 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 2"))
if res1 = n1 and res2 = n2 and res3 = n3 then
acertos = acertos + 1
call etapa3
else
erros = erros + 1
msgbox("Sequência incorreta!!! Total de acertos: "&acertos&""+vbnewline &_
       "Total de erros: "&erros)
call denovo
end if
end sub

sub etapa3()
audio.speak(n1&" "&n2&"  "&n3&"e"&n4)
res1 = cint(inputbox("Digite o valor que você ouviu!"+vbnewline &_
                     "PS:Digite o número que ouviu e depois o outro!","Memorizando Etapa 3"))
res2 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 3"))
res3 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 3"))
res4 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 3"))
if res1 = n1 and res2 = n2 and res3 = n3 and res4 =n4 then
acertos = acertos + 1
call etapa4
else
erros = erros + 1
msgbox("Sequência incorreta!!! Total de acertos: "&acertos&""+vbnewline &_
       "Total de erros: "&erros)
call denovo
end if
end sub

sub etapa4()
audio.speak(n1&" "&n2&"  "&n3&" "&n4&"e"&n5)
res1 = cint(inputbox("Digite o valor que você ouviu!"+vbnewline &_
                     "PS:Digite o número que ouviu e depois o outro!","Memorizando Etapa 4"))
res2 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 4"))
res3 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 4"))
res4 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 4"))
res5 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 4"))
if res1 = n1 and res2 = n2 and res3 = n3 and res4 =n4 and res5 = n5 then
acertos = acertos + 1
call etapa5
else
erros = erros + 1
msgbox("Sequência incorreta!!! Total de acertos: "&acertos&""+vbnewline &_
       "Total de erros: "&erros)
call denovo
end if
end sub

sub etapa5()
audio.speak(n1&" "&n2&"  "&n3&" "&n4&"  "&n5&" e "&n6)
res1 = cint(inputbox("Digite o valor que você ouviu!"+vbnewline &_
                     "PS:Digite o número que ouviu e depois o outro!","Memorizando Etapa 5"))
res2 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 5"))
res3 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 5"))
res4 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 5"))
res5 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 5"))
res6 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 5"))
if res1 = n1 and res2 = n2 and res3 = n3 and res4 =n4 and res5 = n5 and res6 = n6 then
acertos = acertos + 1
call etapa6
else
erros = erros + 1
msgbox("Sequência incorreta!!! Total de acertos: "&acertos&""+vbnewline &_
       "Total de erros: "&erros)
call denovo
end if
end sub

sub etapa6()
audio.speak(n1&" "&n2&"  "&n3&" "&n4&"  "&n5&" "&n6&" e "&n7)
res1 = cint(inputbox("Digite o valor que você ouviu!"+vbnewline &_
                     "PS:Digite o número que ouviu e depois o outro!","Memorizando Etapa 6"))
res2 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 6"))
res3 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 6"))
res4 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 6"))
res5 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 6"))
res6 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 6"))
res7 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 6"))
if res1 = n1 and res2 = n2 and res3 = n3 and res4 =n4 and res5 = n5 and res6 = n6 and res7=n7 then
acertos = acertos + 1
call etapa7
else
erros = erros + 1
msgbox("Sequência incorreta!!! Total de acertos: "&acertos&""+vbnewline &_
       "Total de erros: "&erros)
call denovo
end if
end sub

sub etapa7()
audio.speak(n1&" "&n2&"  "&n3&" "&n4&"  "&n5&" "&n6&" "&n7&" e "&n8)
res1 = cint(inputbox("Digite o valor que você ouviu!"+vbnewline &_
                     "PS:Digite o número que ouviu e depois o outro!","Memorizando Etapa 7"))
res2 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 7"))
res3 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 7"))
res4 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 7"))
res5 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 7"))
res6 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 7"))
res7 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 7"))
res8 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 7"))
if res1 = n1 and res2 = n2 and res3 = n3 and res4 =n4 and res5 = n5 and res6 = n6 and res7=n7 and res8 = n8 then
acertos = acertos + 1
call etapa8
else
erros = erros + 1
msgbox("Sequência incorreta!!! Total de acertos: "&acertos&""+vbnewline &_
       "Total de erros: "&erros)
call denovo
end if
end sub

sub etapa8()
audio.speak(n1&" "&n2&"  "&n3&" "&n4&"  "&n5&" "&n6&" "&n7&" "&n8&"e"&n9)
res1 = cint(inputbox("Digite o valor que você ouviu!"+vbnewline &_
                     "PS:Digite o número que ouviu e depois o outro!","Memorizando Etapa 8"))
res2 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 8"))
res3 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 8"))
res4 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 8"))
res5 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 8"))
res6 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 8"))
res7 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 8"))
res8 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 8"))
res9 = cint(inputbox("Digite o valor que você ouviu!","Memorizando Etapa 8"))
if res1 = n1 and res2 = n2 and res3 = n3 and res4 =n4 and res5 = n5 and res6 = n6 and res7=n7 and res8 = n8 and res9=n9 then
acertos = acertos + 1
call fim
else
erros = erros + 1
msgbox("Sequência incorreta!!! Total de acertos: "&acertos&""+vbnewline &_
       "Total de erros: "&erros)
call denovo
end if
end sub

sub fim()
    resp=msgbox("PARABÉN VOCÊ ACERTOU TODO A SEQUÊNCIA! (QUE MEMÓRIA EIN) DEJEJA JOGAR NOVAMENTE?",vbinformation+vbyesno,"FIM DO JOGO, VITÓRIA")
    if resp=vbyes then
    call inicio
    else
    audio.speak("Foi muito divertido, até logo.")
    wscript.quit
    end if
end sub

sub denovo()
    resp=msgbox("VOCÊ ERROU A SEQUÊNCIA!!!, DESEJA JOGAR NOVAMENTE?",vbinformation+vbyesno,"FIM DO JOGO, DERROTA")
    if resp=vbyes then
    call inicio
    else
    audio.speak("Foi muito divertido, até logo.")
    wscript.quit
    end if
end sub