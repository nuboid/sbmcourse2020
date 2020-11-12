#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MyBackendService001/MyBackendService001.csproj", "MyBackendService001/"]
RUN dotnet restore "MyBackendService001/MyBackendService001.csproj"
COPY . .
WORKDIR "/src/MyBackendService001"
RUN dotnet build "MyBackendService001.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyBackendService001.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyBackendService001.dll"]