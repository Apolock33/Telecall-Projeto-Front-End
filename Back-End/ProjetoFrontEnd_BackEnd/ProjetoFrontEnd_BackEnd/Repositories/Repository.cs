using Microsoft.EntityFrameworkCore;
using ProjetoFrontEnd_BackEnd.Models.Context;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;
using System;
using System.Linq.Expressions;

namespace ProjetoFrontEnd_BackEnd.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
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
        public async Task<int> Delete(Guid id)
        {
            var getEntity = await Task.Run(() => _db.Set<T>().Find(id));

            if (getEntity != null)
            {
                _db.Set<T>().Remove(getEntity);
            }

            return await _db.SaveChangesAsync();
        }
    }
}
