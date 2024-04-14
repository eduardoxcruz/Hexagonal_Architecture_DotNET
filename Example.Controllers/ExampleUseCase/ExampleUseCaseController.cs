using System.Threading.Tasks;


using SeedWork;


namespace Controllers.ExampleUseCase;

public class ExampleUseCaseController: IController<ExampleOutputDto, ExampleInputDto>
{
    private readonly IExampleUseCaseInputPort _inputPort;
    private readonly IExampleUseCaseOutputPort _outputPort;

    public ExampleUseCaseController(IExampleUseCaseInputPort inputPort, IExampleUseCaseOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    public async ValueTask<ExampleOutputDto> UseCase(ExampleInputDto inputDto)
    {
        await _inputPort.Handle(inputDto);
        return ((IPresenterT<ExampleOutputDto>)_outputPort).Content;
    }
}