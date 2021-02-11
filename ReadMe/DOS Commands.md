#### Most used DOS Commands
```
systeminfo
winver
```
#### DOS command to delete bin & obj Folders
```
@echo off
@echo Deleting all BIN and OBJ folders...
for /d /r . %%d in (bin,obj) do @if exist "%%d" rd /s/q "%%d"
@echo folders have been deleted. Press any key to exit
pause > nul
```

#### DOS command Number of Lines in Txt File in folders, subfolders
```
for /r %f in (*.txt) do find /v /c "" "%f" >>externalref.txt
```

#### DOS Command to clear Event Logger
```
for /F "tokens=*" %1 in ('wevtutil.exe el') DO wevtutil.exe cl "%1
```

#### DOS Command to kill node process
```
taskkill /F /IM node.exe
taskkill /IM "chrome.exe" /F
```
#### DOS Command DateTime Format to variable
```
echo %date% %time%
set sysdatetimeformat=%date:~10,4%%date:~4,2%%date:~7,2%_%time:~0,2%%time:~3,2%_%time:~6,2%%time:~9,2%
echo %sysdatetimeformat%
```
