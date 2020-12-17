echo off
    title Servicos windows
    mode 60,40
    color 0d
    :inicio
    cls
    echo.
    echo ********************************************
    echo *          SERVICOS DE REDE                *
    echo ********************************************
    echo * [N]avegar internet                       *
    echo * [T]estar conexao de rede                 *
    echo * [O]bter o ip da maquina                  *
    echo * [R]etornar ao menu                       *
    echo ********************************************
    set /p op=Digite a opcao desejada :
    if /I %op% == n (goto:nav)
    if /I %op% == t (goto:teste) 
    if /I %op% == o (goto:ip)
    if /I %op% == r (call menu.bat) else (
    echo.
    echo ---------------------
    echo * OPCAO INVALIDA !  *
    echo ---------------------
    pause > nul
    goto:inicio)
    
    :nav
    set /p site=Digite o endereco da pagina :
    start %site%
    goto:inicio

    :teste
    set /p teste=Digite o IP da maquina ou endereco da pagina :
    ping %teste% -t
    goto:inicio

    :ip
    ipconfig 
    pause
    goto:inicio