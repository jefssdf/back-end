using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface IServiceRepository : IBaseRepository<Service>
    {
        Task<IEnumerable<Service>> GetAllServicesByLegalEntityId(Guid id, CancellationToken cancellationToken);
    }
}
