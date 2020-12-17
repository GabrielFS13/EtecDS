echo off
    title Gerenciador da Maquina
    mode 60,20
    color 0d
    :inicio
    cls
    echo.
    echo ********************************************
    echo *       GERENCIADOR DA MAQUINA             *
    echo ********************************************
    echo * [DM]Desligar maquina                     *
    echo * [RM]Reniciar MAquina                     *
    echo * [HM]Hibernar maquina                     *
    echo * [R]etornar ao menu                       *
    echo ********************************************
    echo.
    set /p op=Digite a opcao desejada :
    if /I %op% == dm (goto:desliga)
    if /I %op% == rm (goto:reinicia) 
    if /I %op% == hm (goto:hiberna)
    if /I %op% == r (call menu.bat) else (
    echo.
    echo ---------------------
    echo  OPCAO INVALIDA ! 
    echo ---------------------
    pause > nul
    goto:inicio)

    :desliga
    shutdown /s
    goto:inicio

    :reinicia
    shutdown -r
    goto:inicio

    :hiberna
    shutdown /h /f
    pause
    goto:inicio