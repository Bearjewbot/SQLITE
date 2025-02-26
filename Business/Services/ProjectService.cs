using System.Diagnostics;
using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Business.Services;

public class ProjectService(IProjectRepository projectRepository) : IProjectService
{
    private readonly IProjectRepository _projectRepository = projectRepository;


    public async Task<Project> CreateProjectAsync(ProjectRegister form)
    {
        
        try
        {
            var projectEntity = ProjectFactory.Map(form);

            if (await _projectRepository.CheckIfExistsAsync(x => x.Description == projectEntity.Description))
                return null!;
            
            await _projectRepository.CreateAsync(projectEntity);
            var project = ProjectFactory.Map(projectEntity);
            return project;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null!;
        }
    }
    
    
    public async Task<IEnumerable<Project>> GetProjectsAsync()
    {
        try
        {
            var entities = await _projectRepository.GetAllAsync();
            return entities.Select(ProjectFactory.Map);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return [];
        }
    }

    public async Task<Project> GetProjectAsync(int id)
    {
        try
        {
            var entity = await _projectRepository.GetAsync(x => x.Id == id);
            return ProjectFactory.Map(entity);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null!;
        }
    }

    public async Task<ProjectEntity> UpdateProjectAsync(Project project)
    {
        try
        {
            var entity = ProjectFactory.Map(project);
            return await _projectRepository.UpdateAsync(x => x.Id == entity.Id, entity);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null!;
        }
    }

    public async Task<bool> DeleteProjectAsync(int id)
    {
        try
        {
            return await _projectRepository.DeleteAsync(x => x.Id == id);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return false;
        }
    }
}