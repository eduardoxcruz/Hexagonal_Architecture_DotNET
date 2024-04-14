using $ext_safeprojectname$.Controllers;

using $ext_safeprojectname$.EFCore.Repositories;
using $ext_safeprojectname$.Presenters;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using $ext_safeprojectname$.UseCases;

namespace $ext_safeprojectname$.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddExampleServices(
        this IServiceCollection services,
        IConfiguration configuration,
        string connectionStringName
    )
    {
        services
            .AddExampleEfCoreRepositories(configuration, connectionStringName)
            .AddExampleUseCases()
            .AddExamplePresenters()
            .AddExampleControllers();

        return services;
    }
}