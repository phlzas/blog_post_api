using blog_post_api.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blog_post_api.Repositery.Genric
{
    public class GenricRepo<T> : IGenricRepo<T> where T : class
    {
        protected readonly AppDbContext _context;

        public GenricRepo (AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> add(T item)
        {
            await _context.Set<T>().AddAsync(item);
            saveChanges();
            return item;
        }

        public async Task<T> getById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> getAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> remove(int id)
        {
           T item = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(item);
            saveChanges();
            return item;

        }

        public async void saveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<T> update(T item)
        {
            _context.Set<T>().Update(item);
            saveChanges();
            return item;
        }
    }
}
