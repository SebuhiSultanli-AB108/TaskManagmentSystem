using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.Core.RepositoryInterfaces;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    IQueryable<T> GetAll();
    Task<T?> GetByIdAsync(int id);
    Task<bool> IsExistAsync(int id);
    Task AddAsync(T entity);
    Task DeleteByIdAsync(int id);
    Task DeleteAsync(T entity);
    Task<int> SaveAsync();
}