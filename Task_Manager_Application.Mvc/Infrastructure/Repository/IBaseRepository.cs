using System.Linq.Expressions;

namespace Task_Manager_Application.Mvc.Infrastructure.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<List<T>> ListAsync(Expression<Func<T, bool>> expression);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(Expression<Func<T, bool>> expression);
    }
}
