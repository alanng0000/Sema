@echo off



cd Demo/bin/Debug/net6.0-windows


dotnet Demo.dll



if %ERRORLEVEL% NEQ 0 (
    echo Fail: Code %ERRORLEVEL%
)



cd ../../../..