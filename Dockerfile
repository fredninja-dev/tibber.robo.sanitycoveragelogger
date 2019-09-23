FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY tibber.robo.sanitycoveragelogger.csproj tibber.robo.sanitycoveragelogger/
RUN dotnet restore "tibber.robo.sanitycoveragelogger"
COPY . .

FROM build AS publish
RUN dotnet publish "tibber.robo.sanitycoveragelogger.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "tibber.robo.sanitycoveragelogger.dll"]
