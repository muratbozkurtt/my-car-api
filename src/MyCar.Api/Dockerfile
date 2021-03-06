
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/MyCar.Api/MyCar.Api.csproj", "src/MyCar.Api/"]
COPY ["src/MyCar.Service/MyCar.Service.csproj", "src/MyCar.Service/"]
COPY ["src/MyCar.Data/MyCar.Data.csproj", "src/MyCar.Data/"]
COPY ["src/MyCar.Infrastructure/MyCar.Infrastructure.csproj", "src/MyCar.Infrastructure/"]
COPY ["entrypoint.sh", "/app/publish/entrypoint.sh"]
RUN dotnet restore "src/MyCar.Api/MyCar.Api.csproj"
COPY . .
WORKDIR "/src/src/MyCar.Api"
RUN dotnet build "MyCar.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyCar.Api.csproj" -c Release -o /app/publish

WORKDIR /src
RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyCar.Api.dll"]
