@echo off 

set input=
set /a input =(%1) *(%2)

echo %2 * %1 =%input%
