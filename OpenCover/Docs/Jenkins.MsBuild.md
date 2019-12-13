### Jenkins		
	http://ftp-nyc.osuosl.org/pub/jenkins/war-stable/2.164.3/jenkins.war 
	Command: java -jar jenkins.war 
	Path:	%userprofile%\.jenkins
				
### Jekins Plugins 
* MSBuild 
* GitHub Authentication 
* GitHub Pull Request Builder	

### Jekins Pipeline Commands
```
MSBuild .\ASPXSample\opencover.sln /t:Rebuild /p:Configuration=Release
```

### MSBuild
######	Regedit Path to find the physical path
```
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\2.0
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\3.5
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\14.0
```
######	Physical Path
```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319
C:\Windows\Microsoft.NET\Framework64\v3.5\
C:\Program Files (x86)\MSBuild\14.0\bin\amd64\
C:\Program Files (x86)\MSBuild\Microsoft\VisualStudio
```

### My Local Paths
```
c:
cd C:\Users\anand\Desktop\POC
java -jar jenkins.war

cd C:\Users\anand\.jenkins\workspace\OpenCoverDemo_master\	
MSBuild .\ASPXSample\opencover.sln /t:Rebuild /p:Configuration=Release;BuildingProject=true;OutDir=..\output  
or
msbuild .\ASPXSample\opencover.sln
```
