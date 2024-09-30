FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/ProDiegoV2.Web.Host/ProDiegoV2.Web.Host.csproj", "src/ProDiegoV2.Web.Host/"]
COPY ["src/ProDiegoV2.Web.Core/ProDiegoV2.Web.Core.csproj", "src/ProDiegoV2.Web.Core/"]
COPY ["src/ProDiegoV2.Application/ProDiegoV2.Application.csproj", "src/ProDiegoV2.Application/"]
COPY ["src/ProDiegoV2.Core/ProDiegoV2.Core.csproj", "src/ProDiegoV2.Core/"]
COPY ["src/ProDiegoV2.EntityFrameworkCore/ProDiegoV2.EntityFrameworkCore.csproj", "src/ProDiegoV2.EntityFrameworkCore/"]
WORKDIR "/src/src/ProDiegoV2.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ProDiegoV2.Web.Host", "src/ProDiegoV2.Web.Host"]
COPY ["src/ProDiegoV2.Web.Core", "src/ProDiegoV2.Web.Core"]
COPY ["src/ProDiegoV2.Application", "src/ProDiegoV2.Application"]
COPY ["src/ProDiegoV2.Core", "src/ProDiegoV2.Core"]
COPY ["src/ProDiegoV2.EntityFrameworkCore", "src/ProDiegoV2.EntityFrameworkCore"]
WORKDIR "/src/src/ProDiegoV2.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ProDiegoV2.Web.Host.dll"]
