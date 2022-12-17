FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["编程能力基础.csproj", "./"]
RUN dotnet restore "编程能力基础.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "编程能力基础.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "编程能力基础.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "编程能力基础.dll"]
