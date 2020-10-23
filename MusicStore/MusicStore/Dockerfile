FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src

COPY ["MusicStore.csproj","MusicStore/"]
RUN dotnet restore "MusicStore/MusicStore.csproj"
COPY . ./

FROM build AS publish
RUN dotnet publish "MusicStore.csproj" -c Release -o /app/publish

WORKDIR "/src/MusicStore"


FROM base AS final
WORKDIR /app
COPY --from=publish   /app/publish .
ENTRYPOINT ["dotnet", "MusicStore.dll"]
