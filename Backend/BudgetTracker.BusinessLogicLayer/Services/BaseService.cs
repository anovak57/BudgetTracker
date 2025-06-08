using BudgetTracker.BusinessLogicLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.BusinessLogicLayer.Services;

public class BaseService<T> : IBaseService<T> where T : class
{
    protected readonly IBaseRepository<T> _repository;

    public BaseService(IBaseRepository<T> repository)
    {
        _repository = repository;
    }

    public virtual async Task<T> CreateAsync(T entity)
    {
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> entities)
    {
        await _repository.AddRangeAsync(entities);
        await _repository.SaveChangesAsync();
        return entities;
    }

    public virtual async Task<T?> GetByIdAsync(Guid id)
    {
        return await _repository.FindByIdAsync(id);
    }
    
    public virtual async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        return await _repository.FirstOrDefaultAsync(predicate);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _repository.GetAll().ToListAsync();
    }

    public virtual async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
    {
        return await _repository.FindAsync(predicate).ToListAsync();
    }

    public virtual async Task<T> UpdateAsync(T entity)
    {
        _repository.Update(entity);
        await _repository.SaveChangesAsync();
        return entity;
    }

    public virtual async Task DeleteAsync(T entity)
    {
        _repository.Remove(entity);
        await _repository.SaveChangesAsync();
    }
    
    public virtual async Task DeleteRangeAsync(Expression<Func<T, bool>> predicate)
    {
        await _repository.RemoveRangeAsync(predicate);
        await _repository.SaveChangesAsync();
    }

    public virtual async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
    {
        return await _repository.AnyAsync(predicate);
    }

    public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
    {
        return await _repository.CountAsync(predicate);
    }
}