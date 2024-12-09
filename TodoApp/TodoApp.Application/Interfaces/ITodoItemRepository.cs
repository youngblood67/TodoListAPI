using System.Linq.Expressions;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces
{
    public interface ITodoItemRepository: IBaseRepository<TodoItem>
    {
        Task<IEnumerable<TodoItem>> GetByTodoListIdAsync(int TodoAppId);
    }
}
