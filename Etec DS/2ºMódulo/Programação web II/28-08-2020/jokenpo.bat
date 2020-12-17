@echo off
title Jo-Ken-Po
mode 90,50
color 0a
echo.
echo ******************************************
echo  Para jogar, por favor informe o seu nome
echo ******************************************
set /p nome=Informe seu nome: 
echo.
set /a contadorA =0
set /a contadorB =0
set /a contadorC=0
:inicio
cls 
echo ************************************************************************************
echo.
echo                                          Jo-ken-po
echo.
echo ************************************************************************************
echo                                            OPCOES
echo.       
echo                                         [1] Pedra 
echo                                         [2] Papel
echo                                         [3] Tesoura
echo                                         [4] Spock
echo                                         [5] Lagarto
echo                                         [E] Sair 
echo                                         [R] Regras
echo.
echo *************************************************************************************
echo.
set /p op=Digite a opcao escolhida: 
if /I  %op% == 1 (goto:game1) 
if /I  %op% == 2 (goto:game2) 
if /I  %op% == 3 (goto:game3) 
if /I  %op% == 4 (goto:game4) 
if /I  %op% == 5 (goto:game5) 
if /I  %op% == e  (goto:exit)
if /I  %op% == r (goto:Regras) else (
echo.
echo *********************************************
echo Algo deu errado... que tal tentar novamente?
echo *********************************************
pause > nul
goto:inicio )
echo.

:game1 
echo.
set /a res = (%random% %% 4)+1 
if /I %res% == 1 ( goto:empate) 
if /I %res% == 2 ( goto:derrota)
if /I %res% == 3 ( goto:goto:vitoria)
if /I %res% == 4 ( goto:derrota)
if /I %res% == 5 ( goto:goto:vitoria) else (
echo.)
set /p rg=Deseja continuar novamente?  [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit) 

:game2
set /a res=(%random% %% 4)+1 
if /I %res% == 1 ( goto:vitoria )
if /I %res% == 2 ( goto:empate)
if /I %res% == 3 ( goto:derrota)
if /I %res% == 4 ( goto:vitoria)
if /I %res% == 5 ( goto:derrota)
set /p rg=Deseja continuar novamente?  [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit) 

:game3
set /a res=(%random% %% 4)+1 
if /I %res% == 1 ( goto:derrota )
if /I %res% == 2 ( goto:vitoria)
if /I %res% == 3 ( goto:empate)
if /I %res% == 4 ( goto:derrota)
if /I %res% == 5 ( goto:vitoria)
set /p rg=Deseja continuar novamente?  [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit) 

:game4
set /a res=(%random% %% 4)+1 
if /I %res% == 1 ( goto:vitoria)
if /I %res% == 2 ( goto:derrota)
if /I %res% == 3 ( goto:vitoria)
if /I %res% == 4 ( goto:empate)
if /I %res% == 5 ( goto:derrota)
set /p rg=Deseja continuar novamente?  [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit) 

:game5
set /a res=(%random% %% 4)+1 
if /I %res% == 1 ( goto:derrota )
if /I %res% == 2 ( goto:vitoria)
if /I %res% == 3 ( goto:derrota)
if /I %res% == 4 ( goto:vitoria)
if /I %res% == 5 ( goto:empate)
set /p rg=Deseja continuar novamente? ? [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit) 

:exit
exit

:vitoria
set /a contadorA=%contadorA% + 1
echo.
echo **********************************************************************************************
echo %nome% ganhou pela %contadorA%  vez,pois %nome% jogou a opcao %op%, e a maquina jogou %res% .
echo **********************************************************************************************
goto:placar
set /p rg=Deseja continuar novamente?  [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit)

:derrota
set /a contadorB=%contadorB% + 1
echo.
echo *****************************************************************************************
echo %nome% perdeu pela %contadorB% vez, %nome% jogou a opcao %op%, e a maquina jogou %res% .
echo *****************************************************************************************
goto:placar
set /p rg=Deseja continuar novamente?  [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit)

:empate
set /a contadorC=%contadorC% +1
echo.
echo ***************************************************************************************
echo %nome%  empatou, pois ambos jogaram  a opcao %op%, no total teve %contadorC% empate(s)
echo ***************************************************************************************
goto:placar
set /p rg=Deseja continuar novamente?  [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit)

:placar 
echo.
echo Voce perdeu %contadorB% veze(s)
echo Voce ganhou %contadorA% veze(s)
echo Voce empatou  %contadorC% veze(s)
echo.
echo ******************************************
set /p rg=Deseja continuar novamente?  [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit)

:Regras
echo ************************************************************************************
echo Seguinte, %nome% as regras sao as seguites:
echo Pedra:
echo    Empata com Pedra; ganha de Tesoura e lagarto; perde para Papel e Spock;
echo.
echo Papel
echo    Empata com Papel; ganha de Pedra e Spock; perde para Lagarto e Tesoura;
echo.
echo Tesoura:
echo    Empata com Tesoura; Ganha de papel e Lagarto; perde para Pedra e Spock;
echo. 
echo Spock:
echo    Empata com Spock; ganha de Tesoura e Pedra; perde para papel e Lagarto;
echo.
echo Lagarto:
echo    Empata com Lagarto; Ganha de papel e Spock; perde para Tesoura e Pedra;
echo.
echo ************************************************************************************
set /p rg=Deseja Voltar ao menu? [S]/[N]  
if /I %rg% == s (goto:inicio) else (
goto:exit)