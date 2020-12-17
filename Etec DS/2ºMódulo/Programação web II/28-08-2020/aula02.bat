@echo off

 title Gerenciamento de Arquivos

 mode 60,20

 color 4f

 :inicio

 cls

 echo.

 echo ------------------------------

 echo GERENCIMENTO DE ARQUIVOS

 echo ------------------------------

 echo [1] Gerar Arquivos

 echo [2] Organizar Arquivos

 echo [3] Ocultar Arquivos / Pastas

 echo [4] Exibir Arquivos / Pastas

 echo [5] Excluir Arquivos / Pastas

 echo [6] Finalizar Script

 echo -------------------------------

 set /p op=Digite a opcao desejada:

 if %op% == 1 (goto:gerar)

 if %op% == 2 (goto:organizar)

 if %op% == 3 (goto:ocultar)

 if %op% == 4 (goto:exibir)

 if %op% == 5 (goto:excluir)

 if %op% == 6 (goto:sair) else (

 echo.

 echo -------------------------

 echo Opcao Invalida !

 echo -------------------------

 pause > nul

 goto:inicio)



:gerar

 set /p nome_arquivo=Digite o nome do arquivo a serem gerados:

 set /p qtde=Digite a quantidade de arquivos a serem gerados:

 set /p ext=Digite a extensao do arquivo:

 c:

 cd\Users\Gabriel\Desktop\Etec DS\2ºMódulo\Programação web II\28-08-2020

 for /L %%n in (1,1,%qtde%) do echo PWII > %nome_arquivo%%%n.%ext%

 echo.

 echo ---------------------------------

 echo Arquivos Gerados com Sucesso !

 echo ---------------------------------
 
 pause > nul

 goto:inicio



:organizar

 set /p pasta=Digite o nome da pasta a ser criada:

 set /p ext=Digite a extensao do arquivo a ser organizado:

 md %pasta%

 move *.%ext% c:\Users\Gabriel\Desktop\Etec DS\2ºMódulo\Programação web II\28-08-2020\%pasta%

 echo.

 echo -----------------------------------

 echo Arquivos Organizados com Sucesso!!!

 echo -----------------------------------

 pause > nul

 goto:inicio



:ocultar

 c:

 cd\Users\Gabriel\Desktop\Etec DS\2ºMódulo\Programação web II\28-08-2020

 set /p pasta=Digite a pasta a ser ocultada:

 attrib %pasta% +h +r

 echo.

 echo ----------------------------------

 echo Pasta Ocultada com Sucesso!!!

 echo ----------------------------------

 pause > nul

 goto:inicio



:exibir

 c:

 cd\Users\Gabriel\Desktop\Etec DS\2ºMódulo\Programação web II\28-08-2020

 set /p pasta=Digite a pasta a ser exibida:

 attrib %pasta% -h -r

 echo.

 echo ----------------------------------

 echo Pasta Exibida com Sucesso!!!

 echo ----------------------------------

 pause > nul

 goto:inicio



:excluir

 set /p deleta=Deseja realmente excluir? [S/N]:

 if /i %deleta% == s (

 c:

 cd\Users\Gabriel\Desktop\Etec DS\2ºMódulo\Programação web II\28-08-2020

 set /p pasta=Digite a pasta a ser excluida:

 del /f /s /q %pasta%

 rd %pasta%

 echo.

 echo ---------------------------------

 echo Arquivos e Pastas excluidas !!!

 pause > nul

 goto:inicio) else (

 goto:inicio)



:sair

 set /p finalizar=Deseja realmente sair do programa? [S/N]:

 if /i %finalizar% == s (exit) else (

 goto:inicio)