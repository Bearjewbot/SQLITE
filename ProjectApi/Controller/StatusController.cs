using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjectApi.Controller;

[ApiController]
[Route("api/[controller]")]

public class StatusController(IStatusTypeService statusTypeService) : ControllerBase
{
    private readonly IStatusTypeService _statusTypeService = statusTypeService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _statusTypeService.GetStatusesAsync();
        return Ok(result);
    }
}