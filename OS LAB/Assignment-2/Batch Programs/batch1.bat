echo off;
@REM labeling
:menu 
echo Menu 
echo 1. List All Files 
echo 2. Create Directory 
echo 3. Display Today's Date And Time
echo 4. Make abc.txt file as read-only 
echo 5. Exit from menu  

set /p ch=enter choice 1 to 5

if %ch%==1 goto label-1
if %ch%==2 goto label-2
if %ch%==3 goto label-3
if %ch%==4 goto label-4
if %ch%==5 goto label-5


:label-1
dir /p
goto menu




