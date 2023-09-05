using System.Linq.Expressions;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<int> Post(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Expression<Func<T,bool>> predicate);
        Task<int> Put(T entity);
        Task<int> Delete(T entity);
    }
}
