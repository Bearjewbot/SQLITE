using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class UserContactInfoRepository(DataContext context) : BaseRepository<UserContactInfoEntity>(context)
{
    private readonly DataContext _context = context;
    
}