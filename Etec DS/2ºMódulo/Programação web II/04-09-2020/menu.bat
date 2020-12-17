@echo off
@title Menu de jogos
mode 60,30
color 0a
echo.
:inicio
echo *******************************************
echo  Escolha uma das opcoes abaixo para jogar!
echo *******************************************
echo.
echo *******************************************
echo             [J] Jo-ken-po
echo             [A] Adivinhar Numero
echo             [F] Fechar
echo.
echo *******************************************
echo.
set /p escolha= Qual jogo voce quer jogar? 
if /i %escolha% == j (call jokenpo.bat)
if /i %escolha% == a (call adivinharNumero.bat) 
if /i %escolha% == f (exit) else(
    echo ******************************************
    echo Selecione uma opcao valida!
    echo ******************************************
    echo.
    pause > nul
    goto:inicio)