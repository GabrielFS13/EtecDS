@echo off
title Aula 001 - Prog. Web II
mode 60,20
color 09
:inicio
cls
echo.
echo ================================
echo         OUTRA TELA
echo ================================
echo [R]Etornar a tela principal
echo [O]cultar Arquivos
echo [E]xibir Arquivos
echo =================================
echo.
set /p op=Digite a opcao desejada :
if /I %op% == r (call tela1.bat)
if /I %op% == o (goto:ocultar) 
if /I %op% == e (goto:exibir) else (
    echo.
    echo ---------------------
    echo  OPCAO INVALIDA ! 
    echo ---------------------
    pause > nul
    goto:inicio)

 

:ocultar
 set /p ext=Digite a extensao a ser ocultada :
 attrib *.%ext% +r +h
 echo.
 echo -------------------------------
 echo    Arquivos Ocultados!!!
 echo -------------------------------
 pause > nul
 goto:inicio

 

:exibir
 set /p ext=Digite a extensao a ser exibida :
 attrib *.%ext% -r -h
 echo.
 echo -------------------------------
 echo    Arquivos Exibidos!!!
 echo -------------------------------
 pause > nul
 goto:inicio