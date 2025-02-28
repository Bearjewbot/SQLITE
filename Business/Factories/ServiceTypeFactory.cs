using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class ServiceTypeFactory
{
    public static ServiceType? Map(ServiceTypeEntity entity) => entity == null
        ? null
        : new ServiceType
        {
            Id = entity.Id,
            Type = entity.ServiceType
        };
}