using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TodoApp.Application.Interfaces;
using TodoApp.Domain.Entities;

namespace TodoApp.Infrastructure.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly Context _context;
        public TodoItemRepository(Context context)
        {
            this._context = context;
        }

        public async Task AddAsync(TodoItem item)
        {
            await _context.TodoItems.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var todoItem = await GetByIdAsync(id);
            if (todoItem != null)
            {
                _context.TodoItems.Remove(todoItem);
            }
        }

        public async Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task<IEnumerable<TodoItem>> GetAsync(Expression<Func<TodoItem, bool>> predicat)
        {
            return await _context.TodoItems.Where(predicat).ToListAsync();
        }

        public async Task<TodoItem?> GetByIdAsync(int id)
        {
            return await _context.TodoItems.FindAsync(id);
        }

        public async Task<IEnumerable<TodoItem>> GetByTodoListIdAsync(int todoAppId)
        {

            return await _context.TodoItems.Where(t => t.TodoListId == todoAppId).ToListAsync();
        }

        public async Task<IEnumerable<TodoItem>> GetSingleAsync(Expression<Func<TodoItem, bool>> predicat)
        {
            return await _context.TodoItems.Where(predicat).ToListAsync();
        }

        public Task UpdateAsync(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
