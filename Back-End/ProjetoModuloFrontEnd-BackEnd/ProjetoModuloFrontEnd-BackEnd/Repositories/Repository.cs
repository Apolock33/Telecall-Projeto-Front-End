using Microsoft.EntityFrameworkCore;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;
using System.Linq.Expressions;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories
{
    public class Repository<T>: IRepository<T> where T : class
    {
        private readonly AppDbContext _db;

        public Repository(AppDbContext db)
        {
            _db = db;
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return Task.Run(() => _db.Set<T>().AsEnumerable());
        }

        public async Task<T> GetBy(Expression<Func<T, bool>> entity)
        {
            return await Task.Run(() => _db.Set<T>().Where(entity).FirstOrDefaultAsync());
        }

        public async Task<T> Post(T entity)
        {
            _db.Set<T>().Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Put(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
        public async Task<int> Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            return await _db.SaveChangesAsync();
        }
    }
}
