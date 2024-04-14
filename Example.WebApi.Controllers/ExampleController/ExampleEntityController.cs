﻿using DTOs.ExampleUseCase;

using Microsoft.AspNetCore.Mvc;

using SeedWork;

namespace Example.WebApi.Controllers.ExampleController;

[Route("api/Example")]
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