using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces
{
    public interface ITodoItemRepository
    {
        Task<IEnumerable<TodoItem>> GetAllAsync();
        Task<IEnumerable<TodoItem>> GetAsync(Func<bool,IEnumerable<TodoItem>> predicat);
        Task<TodoItem> GetSingleAsync(Func<bool,TodoItem> predicat);
        Task<IEnumerable<TodoItem>> GetByTodoAppIdAsync(int TodoAppId);
        Task<TodoItem> GetByIdAsync(int id);

        Task AddAsync(TodoItem item);
        Task UpdateAsync(TodoItem item);
        Task DeleteByIdAsync(int id);
    }
}
