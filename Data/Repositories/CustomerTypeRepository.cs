using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class CustomerTypeRepository(DataContext context) : BaseRepository<CustomerTypeEntity>(context)
{
    private readonly DataContext _context = context;
    
}