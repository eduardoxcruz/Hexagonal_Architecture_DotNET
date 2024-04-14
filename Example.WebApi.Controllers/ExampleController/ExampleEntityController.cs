using $ext_safeprojectname$.DTOs.ExampleUseCase;

using Microsoft.AspNetCore.Mvc;

using SeedWork;

namespace $ext_safeprojectname$.WebApi.Controllers.ExampleController;

[Route("api/$ext_safeprojectname$")]
[ApiController]
public class ExampleEntityController : ControllerBase
{
    private readonly IController<ExampleOutputDto, ExampleInputDto> _controller;

    public ExampleEntityController(IController<ExampleOutputDto, ExampleInputDto> controller)
    {
        _controller = controller;
    }

    [HttpGet]
    public async Task<IActionResult> GetExample()
    {
        ExampleInputDto inputDto = new();
        var outputDto = await _controller.UseCase(inputDto);
        return Ok(outputDto);
    }
}