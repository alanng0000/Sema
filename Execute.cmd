@echo off



cd Demo/bin/Debug/net6.0


dotnet Demo.dll



if %ERRORLEVEL% NEQ 0 (
    echo Fail: Code %ERRORLEVEL%
)



cd ../../../..