using Cargo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly Context _context;
        private readonly DbSet<T> _dbset;
        public GenericRepository(Context context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public async Task<T> DeleteAsync(int id)
        {
            var entity=await _dbset.FindAsync(id);
            _dbset.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var all = await _dbset.ToListAsync();
            return all;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var byId= await _dbset.FindAsync(id);
            return byId;
        }

        public async Task<T> PostAsync(T entity)
        {
            await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> PutAsync(T entity)
        {
            _dbset.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
