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
    set /p user=Informe a senha:
    if /I  %user% == falcao (call menu.bat) else (
    echo.
    echo *************************************
    echo * senha invalida, tente novamente   *
    echo *************************************
    pause > nul
    goto:inicio)
    )