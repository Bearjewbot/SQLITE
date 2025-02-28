using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjectApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]

    public class CustomerController(ICustomerService customerService) : ControllerBase
    {
        private readonly ICustomerService _customerService = customerService;
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _customerService.GetCustomersAsync();
            return Ok(result);
        }
    }
}
