using AgendaApi.Domain.Entities;
using System.Linq.Expressions;

namespace AgendaApi.Domain.Interfaces
{
    public interface ISchedulingRepository : IBaseRepository<Scheduling>
    {
        Task<IEnumerable<Scheduling>> GetAllById(Expression<Func<Scheduling, bool>> predicate, CancellationToken cancellationToken);
        Task<IEnumerable<Scheduling>> GetAllByDate(Expression<Func<Scheduling, bool>> predicate, CancellationToken cancellationToken);
        Task<IEnumerable<Scheduling>> GetAllByLegalEntityIdComplete(Expression<Func<Scheduling, bool>> predicate, CancellationToken cancellationToken);
        Task<IEnumerable<Scheduling>> GetAllByNaturalPersonIdComplete(Expression<Func<Scheduling, bool>> predicate, CancellationToken cancellationToken);
    }
}
