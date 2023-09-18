using System.Linq.Expressions;

namespace ProejtoFrontEnd.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task<T> Update(T entity);
        Task<bool> Delete(Guid id);
    }
}
