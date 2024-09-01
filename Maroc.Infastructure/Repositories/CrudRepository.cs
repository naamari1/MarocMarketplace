using Maroc.Core.Interfaces;
using Maroc.Infastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Maroc.Infastructure.Repositories
{
    public class CrudRepository<T> : ICrudRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public CrudRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking(); // Use AsNoTracking for read-only scenarios to improve performance
        }



        public virtual async Task<T> GetByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entity with ID {id} was not found.");
            }
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Add a method to delete an entity
        public virtual async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

    }
}
