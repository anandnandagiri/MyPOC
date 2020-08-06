

# Sample Entity Framework Core 3.1.6 for .NET Core 3.1


#### Install Below Nuget Packages from Package Manager Console
```
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
```

#### Run Below Scaffold Command in Package Manager Console To update from Exiting Database
```
Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=WFM;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force -UseDatabaseNames
```

#### If you don't have Exiting Database Run Below Command So that from Code First model we can create db
```
Enable-Migrations -ContextTypeName WFMContext
Add-Migration InitialCreate
Update-Database
```

