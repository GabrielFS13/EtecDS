dim num(4),y,x,aux,n
dim audio
dim denovo
call realizarFala
sub realizarFala()
set audio=createobject("SAPI.SPVOICE")
audio.volume=100
audio.rate=2
end sub    
call inicio 
sub inicio()
num(1) = cint(inputbox("Informe o primeiro valor:","AVISO"))
num(2) = cint(inputbox("Informe o segundo valor:","AVISO"))
num(3) = cint(inputbox("Informe o terceiro valor:","AVISO"))
num(4) = cint(inputbox("Informe o quarto valor:","AVISO"))

      for a=1 to 4
            for i=1 to 3
                   if num(i) > num(i+1) then
                        aux = num(i)
                        num(i) = num(i+1)
                        num(i+1) = aux
                   end if
            next 
      next 

audio.speak("A ordem dos números é a seguinte: O primeiro é"&num(1)&"O segundo é"&num(2)&"O terceiro é:"&num(3)&"E o quarto é:"&num(4))

      msgbox("1º"&num(1)&""+vbnewline &_
             "2º"&num(2)&""+vbnewline &_
             "3º"&num(3)&""+vbnewline &_
             "4º"&num(4)&" ")
      

call finalizar
end sub
sub finalizar()
denovo=msgbox("Deseja tentar novamente?",vbquestion+vbyesno,"ATENÇÃO")
if denovo=vbyes then
 call inicio
else
audio.speak("Mereço um MB")
wscript.quit
end if
end sub