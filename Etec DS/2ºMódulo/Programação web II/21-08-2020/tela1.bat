@echo off
title Aula 001 - Prog. Web II
mode 60,20
color 0a
:inicio
cls
echo.
echo ================================
echo         MENU PRINCIPAL
echo ================================
echo [w]Word
echo [E]xcel
echo [A]ccess
echo [P]ower Point
echo [I]nternet
echo [T]estar Conexao de Rede
echo [C]alculadora
echo [O]utra Tela
echo [F]inalizar Programa
echo =================================
echo.
set /p op=Digite a opcao desejada :
if /I %op% == o (call tela2.bat)
if /I %op% == w (goto:word) 
if /I %op% == e (goto:excel)
if /I %op% == a (goto:access)
if /I %op% == p (goto:power)
if /I %op% == i (goto:web)
if /I %op% == t (goto:testar)
if /I %op% == c (goto:calculo)
if /I %op% == f (exit) else (
    echo.
    echo ---------------------
    echo  OPCAO INVALIDA ! 
    echo ---------------------
    pause > nul
    goto:inicio)

 

:word
start winword.exe 
goto:inicio

 

:excel
start excel.exe
goto:inicio

 

:access
start msaccess.exe
goto:inicio

 

:power
start powerpnt.exe 
goto:inicio

 

:web
set /p site=Digite o endereco da pagina :
start %site%
goto:inicio

 

:testar
set /p teste=Digite o IP da maquina ou endereco da pagina :
ping %teste% -t
goto:inicio

 

:calculo
start calc.exe
goto:inicio