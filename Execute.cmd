@echo off



cd Demo/bin/Debug/net7.0


dotnet Demo.dll



if %ERRORLEVEL% NEQ 0 (
    echo Fail: Code %ERRORLEVEL%
)



cd ../../../..