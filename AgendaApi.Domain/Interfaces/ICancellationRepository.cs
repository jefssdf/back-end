using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface ICancellationRepository : IBaseRepository<Cancellation>
    {
        Task<IEnumerable<Cancellation>> GetAllByOwner(Guid id, CancellationToken cancellationToken);
    }
}
