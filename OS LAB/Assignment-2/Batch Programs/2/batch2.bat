@echo off
pushd
call %1
if not exist %1 call hello.exe
echo.
popd

