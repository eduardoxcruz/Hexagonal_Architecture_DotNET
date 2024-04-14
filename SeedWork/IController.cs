using System.Threading.Tasks;

namespace SeedWork;

public interface IController<TOutputDto, in TInputDto> 
    where TOutputDto : EmptyDto
    where TInputDto : EmptyDto
{
    ValueTask<TOutputDto> UseCase(TInputDto inputDto);
}