using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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