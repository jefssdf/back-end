using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : Person
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetById(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
    }
}
