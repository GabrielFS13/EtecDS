dim cor,cores,resp 
call carregarCores
sub carregarCores()
cores=cint(inputbox("[1] Verde"+vbnewline &_
                    "[2] Amarelo"+vbnewline &_
                    "[3] Vermelho"+vbnewline &_
                    "[0 e 10] Encerrar Script","SELECIONE UMA COR DO SEMÁFORO"))
    select case cores
        case 1:
            cor="Siga em frente"
        case 2:
            cor="Atenção"
        case 3:
            cor="Pare"
        case 0,10:
            resp=msgbox("Deseja encerrar o script?",vbquestion+vbyesno,"ATENÇÃO")
            if resp=vbyes then
                wscript.quit
            else
                call carregarCores
            end if
        case else
        msgbox("Cor inválida do semáforo"),vbexclamation+vbokonly,"ATENÇÃO"
        call carregarCores
    end select
    msgbox("A cor escolhido foi: "&cor&""),vbinformation+vbokonly,"AVISO"
    call carregarCores
end sub