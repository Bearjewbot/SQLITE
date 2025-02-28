using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTypeController(IServiceTypeService serviceTypeService) : ControllerBase
    {
        private readonly IServiceTypeService _serviceTypeService = serviceTypeService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _serviceTypeService.GetServicesAsync();
            return Ok(result);
        } 
    }
}
