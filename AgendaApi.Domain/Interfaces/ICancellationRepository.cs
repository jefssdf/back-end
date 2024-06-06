using AgendaApi.Domain.Entities;
using System.Linq.Expressions;

namespace AgendaApi.Domain.Interfaces
{
    public interface ICancellationRepository : IBaseRepository<Cancellation>
    {
        Task<IEnumerable<Cancellation>> GetAllByOwner(Expression<Func<Cancellation, bool>> predicate, CancellationToken cancellationToken);
    }
}
