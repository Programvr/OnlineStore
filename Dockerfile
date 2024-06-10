# Establece la imagen base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Establece la imagen base para la construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["OnlineStore.API/OnlineStore.API.csproj", "OnlineStore.API/"]
COPY ["OnlineStore.Application/OnlineStore.Application.csproj", "OnlineStore.Application/"]
COPY ["OnlineStore.Infrastructure/OnlineStore.Infrastructure.csproj", "OnlineStore.Infrastructure/"]
RUN dotnet restore "OnlineStore.API/OnlineStore.API.csproj"
COPY . .
WORKDIR "/src/OnlineStore.API"
RUN dotnet build "OnlineStore.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineStore.API.csproj" -c Release -o /app/publish

# Configura la imagen final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineStore.API.dll"]
