using System.Diagnostics;
using Business.Models;
using Data.Entities;
using Business.Factories;
using Business.Interfaces;
using Data.Interfaces;

namespace Business.Services;

public class StatusTypeService(IStatusTypeRepository statusTypeRepository) : IStatusTypeService
{
    private readonly IStatusTypeRepository _statusTypeRepository = statusTypeRepository;
    
    public async Task<IEnumerable<StatusType>> GetStatusesAsync()
    {

        var entity =  await _statusTypeRepository.GetAllAsync();

        try
        {
            return entity.Select(StatusFactory.Map);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null!;
        }
    }
}