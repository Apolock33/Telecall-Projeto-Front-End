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

        public async Task<T> GetById(Expression<Func<T, bool>> entity)
        {
            return await Task.Run(() => _db.Set<T>().Where(entity).FirstOrDefaultAsync());
        }

        public async Task<int> Post(T entity)
        {
            _db.Set<T>().Add(entity);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> Put(T entity)
        {
            _db.Set<T>().Update(entity);
            return await _db.SaveChangesAsync();
        }
        public async Task<int> Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            return await _db.SaveChangesAsync();
        }
    }
}
