FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ENV ASPNETCORE_URLS=http://+:8000
WORKDIR /app
EXPOSE 8000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OtusDocker/OtusDocker.csproj", "OtusDocker/"]
RUN dotnet restore "OtusDocker/OtusDocker.csproj"
COPY . .
WORKDIR "/src/OtusDocker"
RUN dotnet build "OtusDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OtusDocker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OtusDocker.dll"]
