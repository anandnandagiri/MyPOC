#### Entity Framework Scaffolding

Add Nuget Packages
```
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.Sqlite
```

Add Connection String
```
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=mydb;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
```

Generate Code Entity DB Context (DB First Approach)
```
Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=mydb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force -UseDatabaseNames
Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=mydb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model -Context "MyDBContext" -DataAnnotations -force
```
\
Scaffold Template location
```
%USERPROFILE%\.nuget\packages\microsoft.visualstudio.web.codegenerators.mvc
```
\
Make Sure You Have Below AddDbContext in Startup
```
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<MyContext>(options =>
      options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
      );
...
```
\
Most Used Dotnet Core Commands
```
dotnet watch run
```
\
Most Used Create Table With Common Fields
```	
CREATE TABLE [dbo].[MyTable] (
    [ID]         INT   IDENTITY (1, 1) PRIMARY KEY NOT NULL ,
    [Name]       VARCHAR (50) NULL,
    
    [Isactive]   BIT          DEFAULT ((1)) NOT NULL,
    [CreatedDate] DATETIME     DEFAULT (getdate()) NOT NULL,
    [ModifiedDate] DATETIME   NULL,    
    //CONSTRAINT [FK_GData_ServiceID] FOREIGN KEY ([GServiceID]) REFERENCES [dbo].[GService] ([ID])
);
```
\
Migrate SQL Server Table To SQLlite Tables
```
Step 1:	Delete Migrations Folder If exists
Step 2: Run Below commands in Package Manager Console with project selected
            Add-Migration InitialCreate

Step 3: Replace ALL FILES below text in Migrations Folder such as MyDBContextModelSnapshot.cs
            getdate()----->CURRENT_TIMESTAMP

        Above issue Got Resolved After Adding VAapps.EM.DB with Nuget Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
        Also Added base.OnModelCreating(modelBuilder); in MyDBContext.cs in method 
            protected override void OnModelCreating(ModelBuilder modelBuilder)

Step 4: Run Below commands in Package Manager Console with project selected
		    Update-Database

```
