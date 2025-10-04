# 🚀 .NET CLI Commands Cheat Sheet

## 🔹 Project & Solution Management
`dotnet new <template> -n <Name>`       # Create a new project from template  
`dotnet new sln -n <SolutionName>`      # Create a new solution file  
`dotnet sln add <Project.csproj>`       # Add project to solution  
`dotnet sln list`                       # List all projects in solution  

## 🔹 Build, Run & Test
`dotnet build`                          # Build the project  
`dotnet run`                            # Run the project  
`dotnet clean`                          # Clean build outputs  
`dotnet test`                           # Run unit tests  

## 🔹 Dependency Management
`dotnet add package <PackageName>`      # Add a NuGet package  
`dotnet remove package <PackageName>`   # Remove a NuGet package  
`dotnet list package`                   # List installed packages  
`dotnet restore`                        # Restore project dependencies  

## 🔹 Tooling
`dotnet tool install -g <ToolName>`     # Install a global tool  
`dotnet tool update -g <ToolName>`      # Update a global tool  
`dotnet tool list -g`                   # List installed global tools  

## 🔹 Entity Framework (requires dotnet-ef tool)
`dotnet ef migrations add <Name>`       # Create a new migration  
`dotnet ef database update`             # Apply migrations to database  
`dotnet ef migrations list`             # List migrations  
`dotnet ef dbcontext list`              # Show available DbContexts  

## 🔹 Publish & Deployment
`dotnet publish -c Release -o <Path>`   # Publish the app for deployment  

## 🔹 Information & SDK
`dotnet --info`                         # Show .NET information  
`dotnet --list-sdks`                    # List installed SDKs  
`dotnet --list-runtimes`                # List installed runtimes  
`dotnet --version`                      # Show current SDK version  

## 🔹 Template & View Management
`dotnet new list`                       # List all available templates  
