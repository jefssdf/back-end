using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface IServiceRepository : IBaseRepository<Service>
    {
        Task<Service> GetById(Guid id, CancellationToken cancellationToken);
    }
}
