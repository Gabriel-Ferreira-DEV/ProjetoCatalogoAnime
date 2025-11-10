# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o csproj e restaura dependências
COPY AnimeApi.csproj ./
RUN dotnet restore

# Copia todo o restante do código
COPY . .
RUN dotnet build -c Release -o /app/build /p:UseAppHost=false

# Publica a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/build ./
ENTRYPOINT ["dotnet", "AnimeApi.dll"]
