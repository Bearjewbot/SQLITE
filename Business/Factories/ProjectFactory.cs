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
                Customer = new Customer
                {
                    Id = entity.Customer.Id,
                    Name = entity.Customer.Name
                },
                User = new User
                {
                    Id = entity.User.Id,
                    FirstName = entity.User.FirstName,
                    LastName = entity.User.LastName
                },
                StatusType = new StatusType
                {
                    Id = entity.Status.Id,
                    Type = entity.Status.StatusType
                },
                Service = new ServiceType
                {
                    Id = entity.Service.Id,
                    Type = entity.Service.ServiceType
                }
            };
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null!;
        }
    }

    public static ProjectEntity Map(ProjectRegister form)
    {
        try
        {
            return new ProjectEntity
            {
                Description = form.Description,
                Notes = form.Notes,
                StartDate = form.StartDate,
                EndDate = form.EndDate,
                Customer = new CustomerEntity
                {
                    Id = form.CustomerId
                },
                User = new UserEntity
                {
                    Id = form.UserId
                },
                Status = new StatusTypeEntity
                {
                    Id = form.StatusId
                },
                Service = new ServiceTypeEntity
                {
                    Id = form.ServiceId
                }
            };
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null!;
        }
    }

    public static ProjectEntity Map(Project project)
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
                Customer = new CustomerEntity
                {
                    Id = project.Customer.Id
                },
                User = new UserEntity
                {
                    Id = project.User.Id
                },
                Status = new StatusTypeEntity
                {
                    Id = project.StatusType.Id
                },
                Service = new ServiceTypeEntity
                {
                    Id = project.Service.Id
                }
            };
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return null!;
        }
    }
}