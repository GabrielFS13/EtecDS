dim x,y,z
dim maior,menor
dim audio
dim denovo

call realizarFala()
sub realizarFala() 
set audio=createobject("SAPI.SPVOICE")
audio.volume=100
audio.rate=2

call inicio 
end sub
sub inicio()
x=cint(inputbox("Informe o primeiro valor:","AVISO"))
y=cint(inputbox("Informe o segundo valor:","AVISO"))
z=cint(inputbox("Informe o terceiro valor:","AVISO"))

if x>y and x>z and y>z then  
maior = x
menor = z
elseif x>y and x>z and z>y then 
maior = x
menor = y
elseif y>x and y>z and x>z then 
maior = y 
menor = z
elseif y>x and y>z and z>x then 
maior = y
menor = x
elseif z>x and z>y and y>x then 
maior = z 
menor = x
else
maior = z
menor = y
end if
audio.speak ("O maior e menor número é:" + vbnewline &_
 "Maior: "& maior &"" + vbnewline & _
 "Menor: "& menor &"")
msgbox("================================="+ vbnewline &_
      "        Maior e menor número      "+ vbnewline &_
       "================================="+vbnewline &_
        "Maior número:"&maior&" "+ vbnewline &_
        "Menor número:"&menor& " "), vbinformation+vbokonly,"AVISO"
call finalizar
end sub
sub finalizar()
denovo=msgbox("Deseja tentar novamente?",vbquestion+vbyesno,"ATENÇÃO")
if denovo=vbyes then
 call inicio
else
audio.speak("Até logo")
wscript.quit
end if
end sub