using $ext_safeprojectname$.DTOs.ExampleUseCase;

using SeedWork;

using $ext_safeprojectname$.UseCasesPorts.ExampleUseCase;

namespace $ext_safeprojectname$.Presenters.ExampleUseCase;

public class ExampleUseCasePresenter : IPresenterT<ExampleOutputDto>, IExampleUseCaseOutputPort
{
    public ExampleOutputDto Content { get; private set; }

    public ValueTask Handle(ExampleOutputDto dto)
    {
        Content = dto;
        return ValueTask.CompletedTask;
    }
}