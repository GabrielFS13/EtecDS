dim n1,n2,n3,media,sit,resp 'cometário: variáveis locais'
dim audio

call carregar_fala
sub carregar_fala()
set audio=createobject("SAPI.SPVOICE")
audio.volume=100
audio.rate=2'velocidade da fala'
call inicio 
end sub

sub inicio()
n1=cdbl(inputbox("Digite a nota 1","AVISO"))'cdbl=Conversao para double e cint num inteiro'
'se não usar numero use direto inputbox'
n2=cdbl(inputbox("Digite a nota 2","AVISO"))
n3=cdbl(inputbox("Digite a nota 3","AVISO"))
media=round((n1+n2+n3)/3,1)'round para arredondar, o numero dps da , define a quantidade casas dps da vírgula'
if media < 4 then
sit="Reprovado"
elseif media<=7 then
sit="Aprovado"
else 
sit="Recuperação"
end if

'Duas saidas de dados possíveis (mensagem e audio)


audio.speak ("Rendimento do Aluno" + vbnewline &_
 "Média do aluno: "& media &"" + vbnewline & _
 "Situação Final: "& sit &"")
msgbox("================================="+ vbnewline &_
      "        RENDIMENTO DO ALUNO       "+ vbnewline &_
       "================================="+vbnewline &_
        "Média do aluno:"&media&" "+ vbnewline &_
        "Situação Final:"&sit& " "), vbinformation+vbokonly,"AVISO"
call finalizar
end sub'finalizar codigo'

sub finalizar()
resp=msgbox("Deseja realizar um novo cálculo?",vbquestion+vbyesno,"ATENÇÃO")
if resp=vbyes then
 call inicio
else
audio.speak("Até logo")
wscript.quit
end if
end sub