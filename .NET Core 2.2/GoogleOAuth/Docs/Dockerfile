FROM mcr.microsoft.com/dotnet/core/sdk:2.2.204-alpine3.9 AS build
WORKDIR /app

COPY . .
RUN dotnet restore
RUN dotnet publish /app/GoogleOAuth/GoogleOAuth.csproj -c Release -o /app/out


FROM mcr.microsoft.com/dotnet/core/aspnet:2.2.5-alpine3.9 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "GoogleOAuth.dll"]