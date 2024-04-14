
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace $ext_safeprojectname$.EFCore.Repositories;

public static class DependencyContainer
{
    public static IServiceCollection AddExampleEfCoreRepositories(
        this IServiceCollection services,
        IConfiguration configuration,
        string connectionEntry)
    {
        services.AddDbContext<ExampleDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(connectionEntry)));

        services.AddScoped<IExampleEntityWritableRepo, ExampleEntityWritableRepository>();

        return services;

    }
}