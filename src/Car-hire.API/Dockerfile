FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app 
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Car-hire.API/Car-hire.API.csproj", "src/Car-hire.API/"]
RUN dotnet restore "src/Car-hire.API/Car-hire.API.csproj"
COPY . . 
WORKDIR "/src/src/Car-hire.API"
RUN dotnet build "Car-hire.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Car-hire.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Car-hire.API.dll"]