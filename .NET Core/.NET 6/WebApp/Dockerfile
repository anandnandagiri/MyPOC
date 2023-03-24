FROM mcr.microsoft.com/dotnet/sdk:6.0.101-alpine3.14 AS build
WORKDIR /app

COPY . .
RUN dotnet restore
RUN dotnet publish /app/WebApp/WebApp.csproj -c Release -o /app/out


FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine3.14 AS runtime
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

WORKDIR /app
COPY --from=build /app/out ./
EXPOSE 80
ENTRYPOINT ["dotnet", "WebApp.dll"]
