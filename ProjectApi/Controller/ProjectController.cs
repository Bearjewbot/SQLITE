using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProjectApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController(IProjectService projectService) : ControllerBase
    {
        private readonly IProjectService _projectService = projectService;

        [HttpPost]
        public async Task<IActionResult> CreateProject(ProjectRegister form)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            
            var result = await _projectService.CreateProjectAsync(form);
            return Ok(result);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var result = await _projectService.GetProjectsAsync();
                    return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProjectById(int id)
        {
            var result = await _projectService.GetProjectAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProject(ProjectUpdate project)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _projectService.UpdateProjectAsync(project);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            var isDeleted = await _projectService.DeleteProjectAsync(id);
            return isDeleted == false ? NotFound() : NoContent();
        }
    }
}
