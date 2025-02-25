using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class ServiceTypeFactory
{
    public static ServiceType Map(ServiceTypeEntity entity)
    {
        return new ServiceType
        {
            Id = entity.Id,
            Type = entity.ServiceType
        };
    }
}