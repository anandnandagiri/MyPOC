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
wsl --status
wsl -l -v
wsl --update

wsl --set-default-version <Version#>
wsl --set-version <linux distro> 2

wsl -l -o
wsl --install -d  <linux distro>

wsl --set-default <linux distro>
wsl --distribution <linux distro>

wsl --unregister <linux distro>

wsl --terminate <linux distro>
wsl --shutdown
```
#### Troubleshoot 
Not able to Boot Debian/Ubuntu App [More Info](https://utf9k.net/blog/wsl2-vhd-issue/)
\
Network Related Commands IP [More Info](https://raw.githubusercontent.com/anandnandagiri/MyPOC/master/ReadMe/LinuxCommands.md)
