using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }

    public DbSet<TodoList> TodoLists { get; set; }
    public DbSet<TodoItem> TodoItems { get; set; }
    public DbSet<User> Users { get; set; }
}