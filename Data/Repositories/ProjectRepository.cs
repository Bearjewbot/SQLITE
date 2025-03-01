using System.Linq.Expressions;
using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class ProjectRepository(DataContext context) : BaseRepository<ProjectEntity>(context), IProjectRepository
{
    public override async Task<IEnumerable<ProjectEntity>> GetAllAsync()
    {
        try
        {
            var entity = await _context.Projects
                .Include(x => x.Customer)
                .Include(x => x.User)
                .Include(x => x.Status)
                .Include(x => x.Service)
                .ToListAsync();

            return entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return [];
        }   
    }

    public override async Task<ProjectEntity> GetAsync(Expression<Func<ProjectEntity, bool>> expression)
    {
        if (expression == null) throw new ArgumentNullException(nameof(expression));
        try
        {
            var entity = await _context.Projects
                .Include(x => x.Customer)
                .Include(x => x.Status)
                .Include(x => x.User)
                .Include(x => x.Service)
                .FirstOrDefaultAsync(expression);

            return entity!;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null!;
        }
    }
}