@echo off
title Pacote Office
mode 60,20
color 0d
:inicio
cls
echo.
echo ********************************************
echo *       PACOTE OFFICE                      *
echo ********************************************
echo * [w]Word                                  *
echo * [E]xcel                                  *
echo * [A]ccess                                 *
echo * [P]ower Point                            *
echo * [R]etornar ao menu                       *
echo ********************************************
echo.
set /p op=Digite a opcao desejada :
if /I %op% == w (goto:word) 
if /I %op% == e (goto:excel)
if /I %op% == a (goto:access)
if /I %op% == p (goto:power)
if /I %op% == r (call menu.bat) else (
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

