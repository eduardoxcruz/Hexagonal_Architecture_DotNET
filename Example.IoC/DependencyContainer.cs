using Controllers;

using Example.EFCore.Repositories;
using Example.Presenters;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using UseCases;

namespace Example.IoC;

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