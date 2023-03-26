# Defina a imagem base do .NET Core 6 SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Defina o diretório de trabalho para a construção da aplicação
WORKDIR /app

# Copie o arquivo .csproj e restaure as dependências
COPY CatalogoDeLivros/*.sln .
COPY CatalogoDeLivros/*.csproj ./CatalogoDeLivros/CatalogoDeLivros.API/
COPY CatalogoDeLivros.Application/*.csproj ./CatalogoDeLivros/CatalogoDeLivros.Application/
COPY CatalogoDeLivros.Test/*.csproj ./CatalogoDeLivros/CatalogoDeLivros.Test/
RUN dotnet restore

# Copie todo o código-fonte e compile a aplicação
COPY . .
RUN dotnet publish CatalogoDeLivros/CatalogoDeLivros.API -c Release -o out

# Defina a imagem base do .NET Core 6 Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# Defina o diretório de trabalho para a execução da aplicação
WORKDIR /app

# Copie os arquivos publicados da camada de compilação para a imagem de tempo de execução
COPY --from=build-env /app/CatalogoDeLivros/CatalogoDeLivros.API/out .

# Exponha a porta do contêiner usada pela aplicação
EXPOSE 80

# Defina o comando padrão para iniciar o contêiner
ENTRYPOINT ["dotnet", "CatalogoDeLivros.API.dll"]
