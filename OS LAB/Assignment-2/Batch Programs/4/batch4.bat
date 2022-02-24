@echo off

set input=

set /p input=Enter n :

if  %input%=="" set /a input=2

for /l %%i in (1,1,10) do call arithmatic.bat %%i %input%
