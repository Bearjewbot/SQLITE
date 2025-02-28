using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class UserContactInfoRepository(DataContext context) : BaseRepository<UserContactInfoEntity>(context), IUserContactInfoRepository
{
    
}