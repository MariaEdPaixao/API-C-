using TDSPK.API.Infrastructure.Persistence;

namespace TDSPK.API.Repositories
{
    //interface generica para repositorios
    public interface IRepository<T> where T : class // T só pode ser uma classe
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetByUserIdAsync();
        Task AddAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
