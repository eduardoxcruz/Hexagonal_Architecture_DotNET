using Controllers.ExampleUseCase;

using DTOs.ExampleUseCase;

using Microsoft.Extensions.DependencyInjection;

using SeedWork;

namespace Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddExampleControllers(
        this IServiceCollection services)
    {
        services.AddScoped<IController<ExampleOutputDto, ExampleInputDto>, ExampleUseCaseController>();

        return services;
    }
}