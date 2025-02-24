using System.Diagnostics;
using System.Linq.Expressions;
using Data.Contexts;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public abstract class BaseRepository<TEntity>(DataContext context) : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly DataContext _context = context;
    protected readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();
    
    public virtual async Task<TEntity> CreateAsync(TEntity? entity)
    {
        if (entity == null)
        {
            return null!;
        }

        try
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null!;
        }
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        try
        {
            return await _dbSet.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return [];
        }   
        
    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>>? expression)
    {
        if (expression == null)
        {
            return null!;
        }

        return await _dbSet.FirstOrDefaultAsync(expression) ?? null!;
    }

    public virtual async Task<TEntity> UpdateAsync(Expression<Func<TEntity, bool>>? expression, TEntity updatedEntity)
    {
        if (expression == null)
        {
            return null!;
        }

        try
        {
            var currentEntity = await _dbSet.FirstOrDefaultAsync(expression) ?? null;
            if (currentEntity == null)
            {
                return null!;
            }

            _context.Entry(currentEntity).CurrentValues.SetValues(updatedEntity);
            await _context.SaveChangesAsync();

            return currentEntity;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null!;
        }
    }

    public virtual async Task<bool> DeleteAsync(Expression<Func<TEntity, bool>>? expression)
    {
        if (expression == null)
        {
            return false;
        }

        try
        {
            var currentEntity = await _dbSet.FirstOrDefaultAsync(expression) ?? null;
            if (currentEntity == null)
            {
                return false;
            }

            _dbSet.Remove(currentEntity);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return false;
        }
    }
    
    public virtual async Task<bool> CheckIfExistsAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _dbSet.AnyAsync(expression);
    }

}