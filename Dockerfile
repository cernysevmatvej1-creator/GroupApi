FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build 
WORKDIR /src 
COPY ["GroupApi/GroupApi.csproj", "GroupApi/"] 
RUN dotnet restore "GroupApi/GroupApi.csproj" 
COPY . . 
WORKDIR "/src/GroupApi" 
RUN dotnet publish "GroupApi/GroupApi.csproj" -c Release -o /app/publish 
 
FROM mcr.microsoft.com/dotnet/aspnet:9.0 
WORKDIR /app 
EXPOSE 8080 
ENV ASPNETCORE_URLS=http://+:8080 
COPY --from=build /app/publish . 
ENTRYPOINT ["dotnet", "GroupApi.dll"] 
