
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
```

Make Sure You Have Below AddDbContext in Startup
```
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<MyContext>(options =>
      options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
      );
...
```
Most Used Dotnet Core Commands
```
dotnet watch run
```
Most Used Create Table With Common Fields
```	
CREATE TABLE [dbo].[MyTable] (
    [ID]         INT   PRIMARY       IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NULL,
    [Isactive]   BIT          DEFAULT ((1)) NOT NULL,
    [CreateDate] DATETIME     DEFAULT (getdate()) NOT NULL,
    [ModifiedDate] DATETIME   NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    //CONSTRAINT [FK_GData_ServiceID] FOREIGN KEY ([GServiceID]) REFERENCES [dbo].[GService] ([ID])
);
