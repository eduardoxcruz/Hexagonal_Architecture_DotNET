using System.Threading.Tasks;


using SeedWork;


namespace $ext_safeprojectname$.Presenters.ExampleUseCase;

public class ExampleUseCasePresenter: IPresenterT<ExampleOutputDto>, IExampleUseCaseOutputPort
{
    public ExampleOutputDto Content { get; private set; }
    public ValueTask Handle(ExampleOutputDto dto)
    {
        Content = dto;
        return ValueTask.CompletedTask;
    }
}