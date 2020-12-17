@echo off

 set /a cont=0

 :inicio

 cls

 set /a numero=(%random% %% 100) + 1

 echo Numero Sorteado..: %numero%

 set /a cont=%cont% + 1

 echo.

 echo ==========================

 echo QTDE DE SORTEIOS: %cont%

 echo ==========================

 echo.

 pause > nul

 set /p resp=Deseja sortear novo numero? [S/N]..:

 if /I %resp% == S (goto:inicio) else (exit)