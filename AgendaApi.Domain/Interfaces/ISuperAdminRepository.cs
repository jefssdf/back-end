using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface ISuperAdminRepository<T> where T : SuperAdmin
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetById(Guid id, CancellationToken cancellationToken);
        Task<T> GetByEmail(string email, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
    }
}
