using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private CrmDbContext _crmDbContext;

        public GenericRepository()
        {
            _crmDbContext = new CrmDbContext();
        }

        public async Task DeleteAsync(T entity)
        {
            _crmDbContext.Set<T>().Remove(entity);
            await _crmDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _crmDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _crmDbContext.Set<T>().FindAsync(id);
        }

        public async Task InsertAsync(T entity)
        {
            await _crmDbContext.Set<T>().AddAsync(entity);
            await _crmDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _crmDbContext.Set<T>().Update(entity);
            await _crmDbContext.SaveChangesAsync();
        }
    }
}
