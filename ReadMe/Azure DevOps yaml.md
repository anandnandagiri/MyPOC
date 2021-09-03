#### Important Path and Predefined Variables
```
D:\a\1\a      $(Build.ArtifactStagingDirectory)
D:\a\1\s      $(Build.SourcesDirectory)
```
#### YAML Explicit Variable declarations
```
trigger:
- none

jobs:
- job: Phase_1
  displayName: Phase 1
  cancelTimeoutInMinutes: 1
  pool:
    vmImage: vs2017-win2016
  variables:  
    BuildPlatform: 'AnyCPU'
    BuildConfiguration: 'Release'
  steps:
  - checkout: self
  - task: PowerShell@2
```

#### MSBuild Commonly used parameter
```
/p:DeployOnBuild=true /p:WebPublishMethod=Package /p:PackageAsSingleFile=true /p:SkipInvalidConfigurations=true /p:PackageLocation="$(build.artifactstagingdirectory)\\"
'/p:DeployOnBuild=true /p:WebPublishMethod=Package /p:PackageAsSingleFile=true /p:SkipInvalidConfigurations=true /p:PackageLocation="$(build.artifactstagingdirectory)\\"  /p:UseWPP_CopyWebApplication=true  /p:OutDir="$(build.artifactstagingdirectory)" '
```

#### Task Powershell Script to display all files and directories in Build SourcesDirectory & ArtifactStagingDirectory
```
  - task: PowerShell@2
    inputs:
      targetType: 'inline'.
      enabled: true
      script: |        
       echo "$(Build.SourcesDirectory)`r`n$(Build.ArtifactStagingDirectory)`r`n$(System.DefaultWorkingDirectory)"
       Get-ChildItem -Path $(Build.SourcesDirectory) -Recurse
       Get-ChildItem -Path $(Build.ArtifactStagingDirectory) -Recurse
 ```
 
 
 
