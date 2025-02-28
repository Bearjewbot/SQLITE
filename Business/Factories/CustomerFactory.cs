using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class CustomerFactory
{
    public static Customer? Map(CustomerEntity entity) => entity == null
        ? null
        : new Customer
        {
            Id = entity.Id,
            Name = entity.Name,
            ContactPerson = entity.ContactPerson
        };  
}