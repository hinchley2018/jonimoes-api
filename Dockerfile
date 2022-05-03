#LTS sdk 
# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /source

#copy csproj and restore as distinct layers
COPY *.sln .
COPY JonimoesApi/*.csproj ./JonimoesApi/
RUN dotnet restore

#copy everything else and build app
COPY JonimoesApi/. ./JonimoesApi
WORKDIR /source/JonimoesApi
RUN dotnet publish -c release -o /app --no-restore

#final stage image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT [ "dotnet","JonimoesApi.dll" ]