using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class UserFactory
{
    public static User Map(UserEntity entity)
    {
        return new User
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName
        };
    }
}