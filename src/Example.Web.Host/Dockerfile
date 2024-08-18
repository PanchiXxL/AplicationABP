FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Example.Web.Host/Example.Web.Host.csproj", "src/Example.Web.Host/"]
COPY ["src/Example.Web.Core/Example.Web.Core.csproj", "src/Example.Web.Core/"]
COPY ["src/Example.Application/Example.Application.csproj", "src/Example.Application/"]
COPY ["src/Example.Core/Example.Core.csproj", "src/Example.Core/"]
COPY ["src/Example.EntityFrameworkCore/Example.EntityFrameworkCore.csproj", "src/Example.EntityFrameworkCore/"]
WORKDIR "/src/src/Example.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Example.Web.Host", "src/Example.Web.Host"]
COPY ["src/Example.Web.Core", "src/Example.Web.Core"]
COPY ["src/Example.Application", "src/Example.Application"]
COPY ["src/Example.Core", "src/Example.Core"]
COPY ["src/Example.EntityFrameworkCore", "src/Example.EntityFrameworkCore"]
WORKDIR "/src/src/Example.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Example.Web.Host.dll"]
