using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities;

namespace TodoApp.Infrastructure.Data
{
    public class Context : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoApp.Domain.Entities.TodoApp> TodoApps { get; set; }
    }
}
