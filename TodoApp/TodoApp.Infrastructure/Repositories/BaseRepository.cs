using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TodoApp.Application.Interfaces;
using TodoApp.Domain.Entities;

namespace TodoApp.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly Context _context;

        public BaseRepository(Context context)
        {
            this._context = context;
        }

        public async Task AddAsync(TEntity item)
        {
            await _context.Set<TEntity>().AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity item)
        {
            _context.Set<TEntity>().Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var TEntity = await GetByIdAsync(id);
            if (TEntity != null)
            {
                _context.Set<TEntity>().Remove(TEntity);
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicat)
        {
            return await _context.Set<TEntity>().Where(predicat).ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }



        public async Task<TEntity?> GetSingleAsync(Expression<Func<TEntity, bool>> predicat)
        {
            return await _context.Set<TEntity>().Where(predicat).FirstOrDefaultAsync();
        }

      
    }
}
