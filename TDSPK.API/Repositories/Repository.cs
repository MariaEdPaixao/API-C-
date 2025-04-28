using TDSPK.API.Infrastructure.Persistence;

namespace TDSPK.API.Repositories
{
    // implementa a interface generica para repositorios em uma classe generica 
    public class Repository<T> : IRepository<Photo>
    {
        public Task AddAsync(Photo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Photo> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Photo>> GetByUserIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
