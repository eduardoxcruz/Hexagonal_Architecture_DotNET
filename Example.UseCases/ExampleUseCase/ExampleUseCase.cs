using $ext_safeprojectname$.DTOs.ExampleUseCase;

using $ext_safeprojectname$.Repositories;

using $ext_safeprojectname$.Model.Entities;

using $ext_safeprojectname$.UseCasesPorts.ExampleUseCase;

namespace UseCases.ExampleUseCase;

public class ExampleUseCase : IExampleUseCaseInputPort
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
        ExampleEntity entity = new(dto.Name);
        string id = await _writableRepository.Create(entity);
        ExampleOutputDto outputDto = new(id);
        Console.WriteLine(outputDto.Id);
        await _outputPort.Handle(outputDto);
    }
}