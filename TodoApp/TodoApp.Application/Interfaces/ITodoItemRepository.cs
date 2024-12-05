using System.Linq.Expressions;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces
{
    public interface ITodoItemRepository
    {
        Task<IEnumerable<TodoItem>> GetAllAsync();
        Task<IEnumerable<TodoItem>> GetAsync(Expression<Func<TodoItem, bool>> predicat);
        Task<TodoItem> GetSingleAsync(Expression<Func<TodoItem, bool>> predicat);
        Task<IEnumerable<TodoItem>> GetByTodoListIdAsync(int TodoAppId);
        Task<TodoItem?> GetByIdAsync(int id);

        Task AddAsync(TodoItem item);
        Task UpdateAsync(TodoItem item);
        Task DeleteByIdAsync(int id);
    }
}
