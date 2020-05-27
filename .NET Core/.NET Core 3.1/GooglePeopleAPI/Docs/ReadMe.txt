External Links
	https://developers.google.com/api-client-library/dotnet/apis/
	https://github.com/googleapis/google-api-dotnet-client/issues/1486

	https://www.yogihosting.com/implementing-google-contacts-api-version-3-0-oauth-2-0-in-csharp-and-asp-net/
	
	https://developers.google.com/people/v1/getting-started
	https://developers.google.com/people/v1/how-tos/authorizing
	https://developers.google.com/people/api/rest	
	
	https://developers.google.com/api-client-library/dotnet/guide/aaa_oauth#web-applications-asp.net-mvc

	https://github.com/googleapis/google-api-dotnet-client/tree/master/Src/Support
	https://github.com/googleapis/google-api-dotnet-client/blob/master/Src/Support/Google.Apis.Auth.Mvc/OAuth2/Mvc/AuthorizationCodeMvcApp.cs
	https://github.com/googleapis/google-api-dotnet-client/blob/master/Src/Support/Google.Apis.Auth.Mvc/OAuth2/Mvc/Controllers/AuthCallbackController.cs
	https://github.com/googleapis/google-api-dotnet-client/blob/master/Src/Support/Google.Apis.Auth/OAuth2/LocalServerCodeReceiver.cs

	https://www.nuget.org/packages/Google.Apis.Auth.AspNetCore/


	https://developers.google.com/api-client-library/dotnet/get_started
	https://developers.google.com/api-client-library/dotnet/apis/

	Anand Need to Respond
	https://stackoverflow.com/questions/56812689/how-to-implement-the-google-people-api-in-asp-net-core

	https://stackoverflow.com/questions/38390197/how-to-create-a-instance-of-usercredential-if-i-already-have-the-value-of-access
	https://stackoverflow.com/questions/29776725/saving-oauth-tokens-from-google-api-response-to-database
	
	

	https://github.com/googleapis/google-api-dotnet-client	
	https://github.com/googleapis/google-api-dotnet-client/blob/master/Src/Generated/Google.Apis.PeopleService.v1/Google.Apis.PeopleService.v1.cs	
	https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
	https://github.com/GoogleCloudPlatform/dotnet-docs-samples
	https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-3.1
	https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=visual-studio



Adding Nuget Packages
	
	Install-Package Google.Apis.PeopleService.v1 -Version 1.43.0.1848


	Install-Package Microsoft.AspNetCore.Authentication.Google -Version 3.1.0	
	Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.0
	Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 3.1.0
	Install-Package Microsoft.EntityFrameworkCore.Sqlite -Version 3.1.0
	Install-Package Microsoft.AspNetCore.Identity.UI -Version 3.1.0 [This will add automatically when you scaffold identity]


	https://localhost:5001/signin-google
	Install-Package Microsoft.AspNetCore.Authentication.Google -Version 2.2.0


Technical Notes:
	Revoke Token
	https://accounts.google.com/o/oauth2/revoke?token=


GetAccessTokenForRequestAsync



https://accounts.google.com/o/oauth2/revoke?token=ya29.ImC7BxVuiG1SvSXvzHlWlRo-x0YD2uJ87S7BuCJ5Kt1ljdu8ov3R-_6eizN7ODA3K01i13Mw6FkRdNBIGDlejp23Gl-WhSZss6hnLLmBsdSwe2meywxO2SofIVwkVegzqAk


https://accounts.google.com/o/oauth2/v2/auth?access_type=offline&response_type=code&client_id=110197253841-hrtrba7v56tq2qcrvdr3ig3rc3bk6v3h.apps.googleusercontent.com&redirect_uri=http%3A%2F%2Flocalhost%3A4433%2Fauthorize%2F&scope=profile%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fcontacts.readonly%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fuser.birthday.read%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fuser.emails.read

https://accounts.google.com/o/oauth2/v2/auth?
access_type=offline&
response_type=code&
client_id=110197253841-hrtrba7v56tq2qcrvdr3ig3rc3bk6v3h.apps.googleusercontent.com&
redirect_uri=http%3A%2F%2F52.163.114.57%3A5000%2Fpeople%2F&
scope=profile%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fcontacts.readonly%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fuser.birthday.read%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fuser.emails.read

https://accounts.google.com/o/oauth2/v2/auth?access_type=offline&response_type=code&client_id=110197253841-hrtrba7v56tq2qcrvdr3ig3rc3bk6v3h.apps.googleusercontent.com&redirect_uri=http%3A%2F%2Flocalhost%3A5000%2Fpeople%2F&scope=profile%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fcontacts.readonly%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fuser.birthday.read%20https%3A%2F%2Fwww.googleapis.com%2Fauth%2Fuser.emails.read
http://localhost:5000/people
http://52.163.114.57:5000/people

http://localhost:4433/authorize/?
code=4/vwEHXQwgeZnyZ5Z48sWTJKlYCax1MuRNU_UZTgJeulJaUQdxj4XDzE3um27bTtXHCAJutDl5sF-8uoGoUYlkdT4&
scope=profile%20https://www.googleapis.com/auth/userinfo.profile%20https://www.googleapis.com/auth/contacts.readonly%20https://www.googleapis.com/auth/user.birthday.read%20https://www.googleapis.com/auth/user.emails.read



https://accounts.google.com/o/oauth2/v2/auth?
response_type=code&
client_id=110197253841-gkagn9gllpc7nodu6lgvti02n7hu4trb.apps.googleusercontent.com&
redirect_uri=https%3A%2F%2Fgcp.vaapps.com%2Fsignin-google&
scope=openid%20profile%20email&
state=CfDJ8I5haiGCLaFChTqyiA3hP3Xaa91zd6Lns3GXlVtidZBw-aRrAmxVILbnzzlKkQsHRqnQO20HXh6yapOe79C9ErUpQtfnT8KBpcS5kj2tqY6Fz6Dtw9gfjnAmkRJltFrj-cd9BKbXV6zSexh1JWU1L6sQJySo3jyN-StyXOuCCBRpYN_vIy-ZKXiu-pkudUKENm7KYa9QkYqPVQRZCVpkPE-QFmOl9tZ5t0rf-nf0KMyUHjvGi3MsbrdfPzA00sZK66jM5GB-mfC_q-Rg3wKUl4colDAO-tH1JeC7wrHDxwfeAI4qVBNBIOjTK2OdpUI4jA


52.163.114.57