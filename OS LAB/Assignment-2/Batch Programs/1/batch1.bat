@echo off
@REM labeling
echo.
color a 
:menu 
echo ********** Menu **********
echo 1. List All Files 
echo 2. Create Directory 
echo 3. Display Today's Date And Time
echo 4. Make abc.txt file as read-only 
echo 5. Exit from menu  
echo.

set /p ch=Enter your choice:%=%

if %ch%==1 goto label-1
if %ch%==2 goto label-2
if %ch%==3 goto label-3
if %ch%==4 goto label-4
if %ch%==5 goto label-5


:label-1
echo.
dir /p
echo.
goto menu

:label-2
echo.
md new-dir 
dir /ad
echo.
goto menu

:label-3
echo.
echo Date 
 date /t
echo Time
time /t
echo.
goto menu

:label-4
echo.
notepad abc.txt
attrib +r .\abc.txt 
echo .
echo **** Showing File Types ****
attrib 
echo.
goto menu

:label-5
cls







