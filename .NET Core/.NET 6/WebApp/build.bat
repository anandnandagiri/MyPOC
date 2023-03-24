REM echo %cd%
REM 
REM cd %cd%\WebApp
REM dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true
REM cd ..
REM copy Dockerfile %cd%\WebApp\bin\Release\net6.0\linux-x64\publish\
REM cd %cd%\WebApp\bin\Release\net6.0\linux-x64\publish\


docker build -t webapp .

pause
