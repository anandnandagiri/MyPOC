# Google Storage
This POC is used to list and download all the storage blob

#### Create Storage Admin Service Account (Sample JSON in docs)
```
	Goto https://console.cloud.google.com/
	Navigate to IAM & admin > Service Account
	In Screen
		Click On Create Service Account
		Make Sure you Provided Storage Admin
		Create Key and download JSON
```

#### Added Nuget Packages To Project
```
Install-Package Google.Cloud.Storage.V1 -Version 2.4.0
```
#### Caution
	This will modify environment variable GOOGLE_APPLICATION_CREDENTIALS
	You need to modify appConfig.json as per downloaded JSON from Service account you created
