FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build 
WORKDIR /src 
COPY ["GroupApi.csproj", "./"] 
RUN dotnet restore "GroupApi.csproj" 
COPY . . 
RUN dotnet publish "GroupApi.csproj" -c Release -o /app/publish 
 
FROM mcr.microsoft.com/dotnet/aspnet:9.0 
WORKDIR /app 
EXPOSE 8080 
ENV ASPNETCORE_URLS=http://+:8080 
COPY --from=build /app/publish . 
ENTRYPOINT ["dotnet", "GroupApi.dll"]
