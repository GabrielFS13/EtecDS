echo off
    title Aplicativos Windows
    mode 60,20
    color 0d
    :inicio
    cls
    echo.
    echo ************************
    echo * APLICATIVOS WINDOWS  *
    echo ************************
    echo * [C]alculadora        *
    echo * [T]eclado virtual    *
    echo * [W]indows explorer   *
    echo * [P]aint              *
    echo * [B]loco de notas     *
    echo * [M]anutencao de disco*
    echo * [R]etornar ao menu   *
    echo ************************
    echo.
    set /p op=Digite a opcao desejada :
    if /I %op% == c (goto:calc)
    if /I %op% == t (goto:tecl)
    if /I %op% == p (goto:paint)
    if /I %op% == b (goto:bloco)
    if /I %op% == m (goto:manu)
    if /I %op% == w (goto:explorer)
    if /I %op% == r (call menu.bat)else (
    echo.
    echo ---------------------
    echo  OPCAO INVALIDA ! 
    echo ---------------------
    pause > nul
    goto:inicio)
    
    :calc
    start calc.exe
    goto:inicio

    :tecl
    start osk.exe
    goto:inicio

    :paint
    start mspaint.exe
    goto:inicio

    :bloco
    start notepad.exe
    goto:inicio

    :explorer
    start explorer.exe
    goto:inicio

    :manu
    set /p uni=Digite a unidade de disco:
    chkdsk %uni% /f /v
    pause
    goto:inicio