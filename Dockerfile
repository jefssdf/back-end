# Use a imagem oficial do .NET SDK para a compilação e desenvolvimento
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copie os arquivos de projeto (.csproj) e restaure as dependências
COPY ["AgendaApi.API/AgendaApi.API.csproj", "AgendaApi.API/"]
COPY ["AgendaApi.Application/AgendaApi.Application.csproj", "AgendaApi.Application/"]
COPY ["AgendaApi.Domain/AgendaApi.Domain.csproj", "AgendaApi.Domain/"]
COPY ["AgendaApi.Persistence/AgendaApi.Persistence.csproj", "AgendaApi.Persistence/"]

RUN dotnet restore "AgendaApi.API/AgendaApi.API.csproj"

# Copie todos os arquivos do projeto
COPY . .

# Defina o diretório de trabalho para o projeto principal
WORKDIR /src/AgendaApi.API

# Exponha a porta que a aplicação vai escutar
EXPOSE 5123

# Defina o comando de entrada para executar a aplicação em modo de desenvolvimento
ENTRYPOINT ["dotnet", "run", "--urls", "http://0.0.0.0:5123"]