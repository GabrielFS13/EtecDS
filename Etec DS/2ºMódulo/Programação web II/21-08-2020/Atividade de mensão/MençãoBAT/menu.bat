echo off
    title Menu principal
    mode 60,20
    color 0d
    :inicio
    cls
    echo.
    echo ****************************
    echo *      MENU PRINCIPAL      *
    echo ****************************
    echo * [P]acote Office          *
    echo * [S]ervicos de rede       *
    echo * [A]plicativos windows    *
    echo * [G]erenciador da maquina *
    echo * [E]ncerrar sessao        *
    echo * [F]inalizar programa     *
    echo ****************************
    echo.
    set /p op=Digite a opcao desejada :
    if /I %op% == p (call pacote.bat)
    if /I %op% == s (call servicos.bat) 
    if /I %op% == a (call app.bat)
    if /I %op% == g (call gerenciador.bat)
    if /I %op% == e (call login.bat)
    if /I %op% == f (exit) else (
    echo.
    echo ---------------------
    echo  OPCAO INVALIDA ! 
    echo ---------------------
    pause > nul
    goto:inicio)