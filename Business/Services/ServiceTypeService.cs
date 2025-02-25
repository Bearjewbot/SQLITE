using System.Diagnostics;
using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class ServiceTypeService(IServiceTypeRepository serviceTypeRepository) : IServiceTypeService
{
    private readonly IServiceTypeRepository _serviceTypeRepository = serviceTypeRepository;

    public async Task<IEnumerable<ServiceType>> GetServicesAsync()
    {

        var entity =  await _serviceTypeRepository.GetAllAsync();

        try
        {
            return entity.Select(ServiceTypeFactory.Map);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null!;
        }
    }
}