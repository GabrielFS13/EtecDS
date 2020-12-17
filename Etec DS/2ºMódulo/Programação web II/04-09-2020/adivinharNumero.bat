@echo off
@title Adivinhe o Numero!
mode 90,30
color 0a
echo.
set /a controleV = 0
set /a controleD = 0
set /a tentativas = 5
:inicio
set /a sort = (%random% %% 49)+1
:tentarDNV
echo *************************************************************************************
echo                            Bem vindo ao Adivinhe o Numero!
echo *************************************************************************************
echo      Adivinhe o numero sorteado entre 01 e 50
echo *************************************************************************************
echo                        Voce tem %tentativas% tentativas restantes!
echo *************************************************************************************
echo                Ao todo voce tem %controleD% derrotas
echo                               e %controleV% vitorias
echo *************************************************************************************
echo.
set /p palpite= Digite o seu palpite: 
if %tentativas% == 0 (goto:derrota)
if %palpite% GTR 50 (goto:aviso)
if %palpite% == %sort% (goto:vitoria)
if %palpite% LSS %sort% (goto:menor )
if %palpite% GTR %sort% (goto:maior)
echo.
:aviso
echo ************************************************
echo Digite um numero que esteja entre 01 a 50!
echo ************************************************
pause > nul
cls
goto:tentarDNV
  
:vitoria
echo ********************************
echo Parabens voce acertou o numero!
echo O numero sorteado era: %sort%
echo ********************************
set /a controleV = %controleV% + 1
pause > nul
set /p again=Deseja jogar novamente?[S/N] 
cls
if /i %again% == s (goto:inicio)
if /i %again% == n (exit)

:menor
set /a tentativas= %tentativas% - 1
echo ********************************
echo    Digite um numero Maior!!!!
echo ********************************
pause > nul
cls
goto:tentarDNV

:maior
set /a tentativas= %tentativas% - 1
echo ********************************
echo    Digite um numero Menor!!!!
echo ********************************
pause > nul
cls
goto:tentarDNV

:derrota
echo *******************************************
echo  Voce foi derrotado!
echo o numero sorteado era: %sort%
echo *******************************************
set /a tentativas = 5
set /a controleD = %controleD% + 1
set /p again=Deseja jogar novamente?[S/N] 
cls
if /i %again% == s (goto:inicio)
if /i %again% == n (exit)