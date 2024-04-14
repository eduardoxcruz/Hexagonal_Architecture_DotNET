FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Example.WebAPI/Example.WebAPI.csproj", "Example.WebAPI/"]
COPY ["Example.WebApi.Controllers/Example.WebApi.Controllers.csproj", "Example.WebApi.Controllers/"]
COPY ["Example.IoC/Example.IoC.csproj", "Example.IoC/"]
COPY ["Example.Controllers/Example.Controllers.csproj", "Example.Controllers/"]
COPY ["Example.DTOs/Example.DTOs.csproj", "Example.DTOs/"]
COPY ["Example.Model/Example.Model.csproj", "Example.Model/"]
COPY ["SeedWork/SeedWork.csproj", "SeedWork/"]
COPY ["Example.UseCasesPorts/Example.UseCasesPorts.csproj", "Example.UseCasesPorts/"]
COPY ["Example.EFCore.Repositories/Example.EFCore.Repositories.csproj", "Example.EFCore.Repositories/"]
COPY ["Example.EFCore.DataContext/Example.EFCore.DataContext.csproj", "Example.EFCore.DataContext/"]
COPY ["Example.Repositories/Example.Repositories.csproj", "Example.Repositories/"]
COPY ["Example.Presenters/Example.Presenters.csproj", "Example.Presenters/"]
COPY ["Example.UseCases/Example.UseCases.csproj", "Example.UseCases/"]
RUN dotnet restore "Example.WebAPI/Example.WebAPI.csproj"
COPY . .
WORKDIR "/src/Example.WebAPI"
RUN dotnet build "Example.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Example.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Example.WebAPI.dll"]
