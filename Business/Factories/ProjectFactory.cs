using System.Diagnostics;
using Business.Models;
using Data.Entities;
namespace Business.Factories;

public static class ProjectFactory
{
    public static Project Map(ProjectEntity entity)
    {
        try
        {
            return new Project
            {
                Id = entity.Id,
                Description = entity.Description,
                Notes = entity.Notes,
                Price = entity.Price,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Customer = CustomerFactory.Map(entity.Customer),
                User = UserFactory.Map(entity.User),
                Status = StatusFactory.Map(entity.Status),
                Service = ServiceTypeFactory.Map(entity.Service)
            };
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null;
        }
    }

    public static ProjectEntity? Map(ProjectRegister form)
    {
        try
        {
            return new ProjectEntity
            {
                Description = form.Description,
                Notes = form.Notes,
                StartDate = form.StartDate,
                EndDate = form.EndDate,
                Price = form.Price,
                CustomerEntityId = form.CustomerId,
                UserEntityId = form.UserId,
                StatusTypeEntityId = form.StatusId,
                ServiceTypeEntityId = form.ServiceId
            };
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null;
        }
    }

    public static ProjectEntity? Map(ProjectUpdate project)
    {
        try
        {
            return new ProjectEntity
            {
                Id = project.Id,
                Description = project.Description,
                Notes = project.Notes,
                Price = project.Price,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                CustomerEntityId = project.CustomerId,
                UserEntityId = project.UserId,
                StatusTypeEntityId = project.StatusId,
                ServiceTypeEntityId = project.ServiceId
            };
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null;
        }
    }
}