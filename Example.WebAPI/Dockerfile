FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["$ext_safeprojectname$.WebAPI/$ext_safeprojectname$.WebAPI.csproj", "$ext_safeprojectname$.WebAPI/"]
COPY ["$ext_safeprojectname$.WebApi.Controllers/$ext_safeprojectname$.WebApi.Controllers.csproj", "$ext_safeprojectname$.WebApi.Controllers/"]
COPY ["$ext_safeprojectname$.IoC/$ext_safeprojectname$.IoC.csproj", "$ext_safeprojectname$.IoC/"]
COPY ["$ext_safeprojectname$.Controllers/$ext_safeprojectname$.Controllers.csproj", "$ext_safeprojectname$.Controllers/"]
COPY ["$ext_safeprojectname$.DTOs/$ext_safeprojectname$.DTOs.csproj", "$ext_safeprojectname$.DTOs/"]
COPY ["$ext_safeprojectname$.Model/$ext_safeprojectname$.Model.csproj", "$ext_safeprojectname$.Model/"]
COPY ["SeedWork/SeedWork.csproj", "SeedWork/"]
COPY ["$ext_safeprojectname$.UseCasesPorts/$ext_safeprojectname$.UseCasesPorts.csproj", "$ext_safeprojectname$.UseCasesPorts/"]
COPY ["$ext_safeprojectname$.EFCore.Repositories/$ext_safeprojectname$.EFCore.Repositories.csproj", "$ext_safeprojectname$.EFCore.Repositories/"]
COPY ["$ext_safeprojectname$.EFCore.DataContext/$ext_safeprojectname$.EFCore.DataContext.csproj", "$ext_safeprojectname$.EFCore.DataContext/"]
COPY ["$ext_safeprojectname$.Repositories/$ext_safeprojectname$.Repositories.csproj", "$ext_safeprojectname$.Repositories/"]
COPY ["$ext_safeprojectname$.Presenters/$ext_safeprojectname$.Presenters.csproj", "$ext_safeprojectname$.Presenters/"]
COPY ["$ext_safeprojectname$.UseCases/$ext_safeprojectname$.UseCases.csproj", "$ext_safeprojectname$.UseCases/"]
RUN dotnet restore "$ext_safeprojectname$.WebAPI/$ext_safeprojectname$.WebAPI.csproj"
COPY . .
WORKDIR "/src/$ext_safeprojectname$.WebAPI"
RUN dotnet build "$ext_safeprojectname$.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "$ext_safeprojectname$.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "$ext_safeprojectname$.WebAPI.dll"]
