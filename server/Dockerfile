FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /article-crud

COPY . .

WORKDIR ./WebAPI

ENV DOTNET_URLS=http://+:5000

RUN dotnet dev-certs https --clean
RUN dotnet dev-certs https --verbose

RUN dotnet publish -c Release

EXPOSE 5000
ENTRYPOINT ["dotnet", "/app/WebApi/bin/Release/net6.0/WebApi.dll"]