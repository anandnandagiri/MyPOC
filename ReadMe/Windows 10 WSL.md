#### Access Debian folder in windows
```
option1: Type explorer.exe in debian terminal
option2: \\wsl$\
```

#### Debian/Ubuntu App Package Folder
```
%LOCALAPPDATA%/packages/
```

#### Access Windows Folder in Debian (Example to access c:\Users)
Note: Linux is case sensitive
```
cd /mnt/c/Users/
```

#### WSL Commands 
```
wsl -l -v
wsl.exe --set-version <linux distro> 2
wsl --shutdown
```
#### Troubleshoot 
Not able to Boot Debian/Ubuntu App [More Info](https://utf9k.net/blog/wsl2-vhd-issue/)
\
Network Related Commands IP [More Info](https://raw.githubusercontent.com/anandnandagiri/MyPOC/master/ReadMe/LinuxCommands.md)
