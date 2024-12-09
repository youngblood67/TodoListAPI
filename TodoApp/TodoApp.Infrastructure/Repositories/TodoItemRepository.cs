using Microsoft.EntityFrameworkCore;
using TodoApp.Application.Interfaces;
using TodoApp.Domain.Entities;

namespace TodoApp.Infrastructure.Repositories
{
    public class TodoItemRepository : BaseRepository<TodoItem>, ITodoItemRepository
    {
        public TodoItemRepository(Context context) : base(context)
        {
            
        }
        public async Task<IEnumerable<TodoItem>> GetByTodoListIdAsync(int todoAppId)
        {

            return await _context.TodoItems.Where(t => t.TodoListId == todoAppId).ToListAsync();
        }
    }
}
