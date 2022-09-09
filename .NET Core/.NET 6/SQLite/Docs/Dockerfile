FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine3.14 AS runtime
WORKDIR /app
COPY . .
EXPOSE 8080
ENTRYPOINT ["dotnet", "SQLite.dll","--environment=PI"]