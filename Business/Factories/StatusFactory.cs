using Business.Models;
using Business.Services;
using Data.Entities;

namespace Business.Factories;

public static class StatusFactory
{
    public static StatusType? Map(StatusTypeEntity entity) => entity == null
        ? null
        : new StatusType
        {
            Id = entity.Id,
            Type = entity.StatusType
        };
}