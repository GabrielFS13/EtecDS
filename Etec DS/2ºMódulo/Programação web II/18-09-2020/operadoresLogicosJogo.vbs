dim operador,valor1,valor2,resultado,res,acertos,resp,erros
erros = 0
acertos = 0
call inicio
sub inicio()
randomize(second(time))
operador=int(rnd*4)+1

valor1=int(rnd*10)+1
valor2=int(rnd*10)+1
select case operador
    case 1:
        resultado = valor1+valor2
        res=cint(inputbox("DIGITE O VALOR CORRETO DA SEGUINTE OPERAÇÃO"+vbnewline &_
                    ""&valor1& "+"&valor2&"= ???","Jogo das operações"))
    case 2:
        resultado = valor1-valor2
         res=cint(inputbox("DIGITE O VALOR CORRETO DA SEGUINTE OPERAÇÃO"+vbnewline &_
                       ""&valor1& "-"&valor2&"= ???","Jogo das operações!"))
    case 3:
        resultado = valor1*valor2
         res=cint(inputbox("DIGITE O VALOR CORRETO DA SEGUINTE OPERAÇÃO"+vbnewline &_
                       ""&valor1& "*"&valor2&"= ???","Jogo das operações!"))
    case 4:
        resultado = round((valor1/valor2),1)
         res=cint(inputbox("DIGITE O VALOR CORRETO DA SEGUINTE OPERAÇÃO"+vbnewline &_
                       ""&valor1& "/"&valor2&"= ???","Jogo das operações!"))
    case else
        msgbox("SELECIONE UMA OPÇÃO VÁLIDA!"),vbinformation+vbokonly,"AVISO"
    end select

        if res = resultado then
        acertos = acertos + 1
        msgbox("PARABÉNS VOCÊ ACERTOU!!, AGORA VOCÊ TEM "&acertos&" ACERTOS E: "&erros&" ERROS"),vbexclamation+vbokonly,"ACERTOU!!"
        call inicio
        else 
        erros = erros +1
        call fim
    end if
end sub
sub fim()
    resp=msgbox("Você errou a operação, seu placar atual é de: "&acertos&" acertos e "&erros&" erros. Deseja sair?",vbinformation+vbyesno,"ERRO")
    if resp=vbyes then
    wscript.quit
    else
    call inicio
    end if
end sub