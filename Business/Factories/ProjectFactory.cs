using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class ProjectFactory
{
    public static Project Map(ProjectEntity entity)
    {
        return new Project
        {
            Id = entity.Id,
            Description = entity.Description,
            Notes = entity.Notes,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
            Customer = CustomerFactory.Map(entity.Customer),
            User = UserFactory.Map(entity.User),
            StatusType = StatusFactory.Map(entity.Status),
            Service = ServiceTypeFactory.Map(entity.Service)
        };
    }
}