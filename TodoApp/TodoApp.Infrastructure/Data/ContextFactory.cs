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
    }
}
