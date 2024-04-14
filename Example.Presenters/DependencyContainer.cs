using Example.Presenters.ExampleUseCase;

using Microsoft.Extensions.DependencyInjection;

using UseCasesPorts.ExampleUseCase;

namespace Example.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddExamplePresenters(
        this IServiceCollection services)
    {
        services.AddScoped<IExampleUseCaseOutputPort, ExampleUseCasePresenter>();

        return services;
    }
}