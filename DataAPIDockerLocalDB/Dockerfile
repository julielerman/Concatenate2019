FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
# ENV "ConnectionStrings__Mssql"="Server=(localdb)\\mssqllocaldb;Database=ConcatenateMags;Trusted_Connection=True;"
ENV "ConnectionStrings__Sqlite"="filename=dockerconcatenate.db"
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY ["DataAPI_MySql.csproj", "./"]
RUN dotnet restore "./DataAPI_MySql.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "DataAPI_MySql.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DataAPI_MySql.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DataAPI_MySql.dll"]
