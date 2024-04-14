using $ext_safeprojectname$.Presenters.ExampleUseCase;

using Microsoft.Extensions.DependencyInjection;

using $ext_safeprojectname$.UseCasesPorts.ExampleUseCase;

namespace $ext_safeprojectname$.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddExamplePresenters(
        this IServiceCollection services)
    {
        services.AddScoped<IExampleUseCaseOutputPort, ExampleUseCasePresenter>();

        return services;
    }
}