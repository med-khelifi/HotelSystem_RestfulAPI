using DAL.AppContext;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositries.MainRepo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private protected HotelDbContext _context;
        private protected DbSet<T> _dbSet;

        public Repository(HotelDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<int> AddNew(T item)
        {
            try
            {
                await _dbSet.AddAsync(item);
                return await _context.SaveChangesAsync();
            }
            catch
            {
                // TODO: logging
                return 0;
            }
        }

        public async Task<int> Delete(T item)
        {
            try
            {
                _dbSet.Remove(item);
                return await _context.SaveChangesAsync();
            }
            catch
            {
                // TODO: logging
                return 0;
            }
        }

        public async Task<int> Delete(int id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity == null)
                    return 0;

                _dbSet.Remove(entity);
                return await _context.SaveChangesAsync();
            }
            catch
            {
                // TODO: logging
                return 0;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch
            {
                // TODO: logging
                return Enumerable.Empty<T>();
            }
        }

        public async Task<T?> GetById(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch
            {
                // TODO: logging
                return null;
            }
        }

        public async Task<int> Update(T item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                return await _context.SaveChangesAsync();
            }
            catch
            {
                // TODO: logging
                return 0;
            }
        }
    }
}
