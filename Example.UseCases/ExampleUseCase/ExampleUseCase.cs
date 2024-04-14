using System.Threading.Tasks;


using Interfaces.Repositories;

using SeedWork;


namespace UseCases.ExampleUseCase;

public class ExampleUseCase: IExampleUseCaseInputPort
{
    private readonly IExampleUseCaseOutputPort _outputPort;
    private readonly IExampleEntityWritableRepo _writableRepository;

    public ExampleUseCase(IExampleUseCaseOutputPort outputPort, IExampleEntityWritableRepo writableRepository)
    {
        _outputPort = outputPort;
        _writableRepository = writableRepository;
    }

    public async ValueTask Handle(ExampleInputDto dto)
    {
        ExampleEntity entity = new ExampleEntity(dto.Name);
        string id = await _writableRepository.Create(entity);
        ExampleOutputDto outputDto = new(id);
        await _outputPort.Handle(outputDto);
    }
}