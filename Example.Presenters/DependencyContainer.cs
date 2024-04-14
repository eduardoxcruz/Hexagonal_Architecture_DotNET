using Presenters.ExampleUseCase;
using Microsoft.Extensions.DependencyInjection;


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