using SeedWork;

namespace DTOs.ExampleUseCase;

public class ExampleOutputDto : EmptyDto
{
    public string Id { get; set; }
    
    public ExampleOutputDto(string id)
    {
        Id = id;
    }
}