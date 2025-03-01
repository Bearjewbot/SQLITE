using System.Diagnostics;
using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;
    
    public async Task<IEnumerable<User?>> GetUsersAsync()
    {

        var entity =  await _userRepository.GetAllAsync();

        try
        {
            return entity.Select(UserFactory.Map);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null!;
        }
    }
}