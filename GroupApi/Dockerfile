FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore **/GroupApi.csproj
RUN dotnet publish **/GroupApi.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
EXPOSE 80
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "GroupApi.dll"]