FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["BWS.CMS.Headless.Api/BWS.CMS.Headless.Api.csproj", "BWS.CMS.Headless.Api/"]
RUN dotnet restore "BWS.CMS.Headless.Api/BWS.CMS.Headless.Api.csproj"
COPY . .
WORKDIR "/src/BWS.CMS.Headless.Api"
RUN dotnet build "BWS.CMS.Headless.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BWS.CMS.Headless.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BWS.CMS.Headless.Api.dll"]
