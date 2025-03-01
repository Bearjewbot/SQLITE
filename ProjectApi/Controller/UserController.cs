using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjectApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetUsersAsync();
            return Ok(result);
        } 
    }
}
