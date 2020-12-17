@echo off
    title Login
    mode 60,20
    color 0d
    :inicio
    cls
    echo.
    echo **********************
    echo *       Login        *
    echo **********************
    echo.
    set /p user=Informe o Usuario:
    if /I  %user% == gabriel (call senha.bat) else (
    echo.
    echo *************************************
    echo * usuario invalido, tente novamente *
    echo *************************************
    pause > nul
    goto:inicio)
    )
