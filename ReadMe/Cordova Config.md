##### JAVA_HOME
```
C:\Program Files\Java\jdk1.8.0_181
C:\Program Files (x86)\Java\jdk1.8.0_181
```
##### _JAVA_OPTIONS 
```
-Xmx512M
```

##### ANDROID_HOME
```
%userprofile%\AppData\Local\Android\Sdk
C:\ProgramData\Microsoft\AndroidSDK
```
##### ANDROID_SDK_ROOT
```
%userprofile%\AppData\Local\Android\Sdk
```

##### Path Variables
```
C:\Windows\System32\Wbem;
%ANDROID_SDK_ROOT%\emulator
%ANDROID_SDK_ROOT%\tools
%ANDROID_SDK_ROOT%\tools\bin
%ANDROID_SDK_ROOT%\platform-tools
%ANDROID_SDK_ROOT%\build-tools
%JAVA_HOME%\bin
```
##### Emulator
```
emulator.exe  -avd nexus_5x_api_23
```

#### Hyper V
``` 
Disable: bcdedit /set hypervisorlaunchtype off
Enable: bcdedit /set hypervisorlaunchtype auto
bcdedit /copy {current} /d "Anand – no hypervisor"
bcdedit /set {468af51e-cfc1-11e8-b34a-000d3a1c9b0f} hypervisorlaunchtype off
``` 
https://cordova.apache.org/docs/en/8.x/reference/cordova-plugin-splashscreen/index.html
