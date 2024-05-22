using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
    }
}
