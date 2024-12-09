using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TodoApp.Infrastructure.Data
{
    public static class ContextFactory
    {
        public static void AddInMemoryDatabase(this IServiceCollection services)
        {
            services.AddDbContext<Context>(option =>
                option.UseInMemoryDatabase("TodoAppDb"));
        }

        public static void AddSqlServerDatabase(this IServiceCollection services)
        {
            services.AddDbContext<Context>(option =>
            option.UseSqlServer("Data Source=CHUCKY\\SQLEXPRESS;Initial Catalog=TodoAppDb;Integrated Security=True;Encrypt=False"));
        }
    }
}
