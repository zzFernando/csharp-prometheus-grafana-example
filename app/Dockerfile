# Use uma imagem base do SDK do .NET para construir o app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /app
COPY . .

# Restaura as dependências e compila o projeto
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Usa uma imagem mais leve do .NET para rodar o app
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expor a porta 80
EXPOSE 80

# Comando para rodar o app
ENTRYPOINT ["dotnet", "app.dll"]
