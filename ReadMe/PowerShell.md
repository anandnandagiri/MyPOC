#### Most Used Commands
```
$PSVersionTable

Get-ExecutionPolicy
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser

Get-PSRepository
Set-PSRepository -Name "PSGallery" -InstallationPolicy Trusted
Unregister-PSRepository -Name "PSGallery"

Get-Command -ListImported

Get-InstalledModule
Get-InstalledModule -Name "AzureRM.Automation" -MinimumVersion 1.0 -MaximumVersion 2.0
Install-Module -Name Az -SkipPublisherCheck
Install-Module -Name Az.Compute

Find-Module -Name "BurntToast"

Test-Connection -TargetName google.com -IPv4
```

#### Docker Container for powershell
```
docker run -it --rm mcr.microsoft.com/powershell
docker run -it --rm --network=host mcr.microsoft.com/powershell
```


#### Convert VDHX to VDH
```
Import-Module hyper-v
Convert-VHD –Path C:\VDI\kali-linux-2019.3-hyperv.vhdx –DestinationPath C:\VDI\kali-linux-2019.3-hyperv.vhd
```

#### Troubleshoot Issues found so far
```
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 
Install-Module PowerShellGet -RequiredVersion 2.2.4 -SkipPublisherCheck
Set-PSRepository -Name "PSGallery" -InstallationPolicy Trusted


https://docs.microsoft.com/en-us/powershell/azure/install-az-ps?view=azps-7.3.2
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
Install-Module -Name Az -Scope CurrentUser -Repository PSGallery -Force
```


