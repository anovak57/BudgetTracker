using System.Linq.Expressions;

namespace BudgetTracker.DataAccessLayer.Interfaces;

public interface IBaseRepository<T> where T : class
{
    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Remove(T entity);
    Task RemoveRangeAsync(Expression<Func<T, bool>> predicate);
    Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    IQueryable<T> FindAsync(Expression<Func<T, bool>> predicate);
    Task<T?> FindByIdAsync(Guid id);
    IQueryable<T> GetAll();
    void Update(T entity);
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
    Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    Task<int> SaveChangesAsync();
}