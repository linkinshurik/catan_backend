FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY  Catan.csproj Catan/
RUN dotnet restore Catan/Catan.csproj
COPY . Catan/
WORKDIR /src/Catan
RUN dotnet build Catan.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Catan.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "Catan.dll"]