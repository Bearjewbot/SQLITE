using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class ServiceTypeRepository(DataContext context) : BaseRepository<ServiceTypeEntity>(context)
{
    private readonly DataContext _context = context;
    
}