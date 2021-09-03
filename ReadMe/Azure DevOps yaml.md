#### Important Path and Predefined Variables
```
D:\a\1\a      $(Build.ArtifactStagingDirectory)
D:\a\1\s      $(Build.SourcesDirectory)
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
 
 
 
