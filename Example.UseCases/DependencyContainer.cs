using Microsoft.Extensions.DependencyInjection;


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