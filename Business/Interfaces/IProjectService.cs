using Business.Models;
using Data.Entities;

namespace Business.Interfaces;

public interface IProjectService
{
    Task<Project?> CreateProjectAsync(ProjectRegister form);
    Task<IEnumerable<Project>> GetProjectsAsync();
    Task<Project?> GetProjectAsync(int id);
    Task<ProjectEntity?> UpdateProjectAsync(Project project);
    Task<bool> DeleteProjectAsync(int id);
}