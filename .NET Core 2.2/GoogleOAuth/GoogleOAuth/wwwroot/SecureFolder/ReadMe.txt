External Links
	https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
	https://github.com/GoogleCloudPlatform/dotnet-docs-samples
	https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-3.1
	https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=visual-studio

	https://odetocode.com/blogs/scott/archive/2015/10/06/authorization-policies-and-middleware-in-asp-net-5.aspx


Adding Nuget Packages

	Install-Package Microsoft.EntityFrameworkCore.Sqlite -Version 2.2.4
	Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 2.2.0

Migrate SQL Server Table To SQLlite Tables
	
		Step 1:	Delete Migrations Folder If exists
		Step 2: Run Below commands in Package Manager Console with .EM.DB project selected
				Add-Migration InitialCreate
		Step 3: Replace ALL FILES below text in Migrations Folder such as VAOSMContextModelSnapshot.cs
				getdate()----->CURRENT_TIMESTAMP

				Above issue Got Resolved After Adding .EM.DB with Nuget Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
				Also Added base.OnModelCreating(modelBuilder); in VAOSMContext.cs in method protected override void OnModelCreating(ModelBuilder modelBuilder)

		Step 4: Run Below commands in Package Manager Console with .EM.DB project selected
				Update-Database


	
Technicalities
	Using SQLlite as backend DB
	Used Identity Scaffolding (Areas\identity\Pages\*)
	Added Google OAuth OpenID Authentications
	Added Middleware To Protect SecureFolder with files. Only Authorizated user can access
	Added StaticFiles Mime to support .db file to download.(startup.cs)
	

Adding Nuget Packages
	Install-Package Microsoft.EntityFrameworkCore.Sqlite -Version 2.2.4
	Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 2.2.0

	
Application Menu
	Links
		Google Case Studies
		Google Docs Links
		Online Course
		QwikLabs
		Youtube Playlist
		GitHub Samples	
	OtherDocs


External Links
	https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
	https://github.com/GoogleCloudPlatform/dotnet-docs-samples
	https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-3.1
	https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=visual-studio

	https://odetocode.com/blogs/scott/archive/2015/10/06/authorization-policies-and-middleware-in-asp-net-5.aspx
	https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-3.1
