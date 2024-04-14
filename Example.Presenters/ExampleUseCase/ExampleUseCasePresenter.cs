using DTOs.ExampleUseCase;

using SeedWork;

using UseCasesPorts.ExampleUseCase;

namespace Example.Presenters.ExampleUseCase;

public class ExampleUseCasePresenter : IPresenterT<ExampleOutputDto>, IExampleUseCaseOutputPort
{
    public ExampleOutputDto Content { get; private set; }

    public ValueTask Handle(ExampleOutputDto dto)
    {
        Content = dto;
        return ValueTask.CompletedTask;
    }
}