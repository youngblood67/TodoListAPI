using System.Linq.Expressions;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity item);
        Task UpdateAsync(TEntity item);
        Task DeleteByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicat);
        Task<TEntity?> GetSingleAsync(Expression<Func<TEntity, bool>> predicat);
        Task<TEntity?> GetByIdAsync(int id);
    }
}
