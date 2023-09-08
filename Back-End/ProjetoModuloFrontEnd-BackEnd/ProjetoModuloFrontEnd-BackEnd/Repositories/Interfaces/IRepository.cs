using System.Linq.Expressions;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Post(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetBy(Expression<Func<T,bool>> predicate);
        Task<T> Put(T entity);
        Task<int> Delete(T entity);
    }
}
