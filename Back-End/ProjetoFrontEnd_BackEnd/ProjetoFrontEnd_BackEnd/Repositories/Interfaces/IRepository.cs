using System.Linq.Expressions;

namespace ProjetoFrontEnd_BackEnd.Repositories.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetBy(Expression<Func<T, bool>> predicate);
        Task<T> Post(T entity);
        Task<T> Put(T entity);
        Task<int> Delete(Guid id);
    }
}
