using Microsoft.Extensions.DependencyInjection;

using $ext_safeprojectname$.UseCasesPorts.ExampleUseCase;

namespace UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddExampleUseCases(
        this IServiceCollection services)
    {
        services.AddScoped<IExampleUseCaseInputPort, ExampleUseCase.ExampleUseCase>();

        return services;
    }
}