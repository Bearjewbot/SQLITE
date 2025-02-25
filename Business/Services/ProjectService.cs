using Business.Models;
using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Business.Services;

public class ProjectService(IProjectRepository projectRepository)
{
    private readonly IProjectRepository _projectRepository = projectRepository;

    public async Task<IEnumerable<Project>> GetProjectsAsync()
    {
        
    }
}