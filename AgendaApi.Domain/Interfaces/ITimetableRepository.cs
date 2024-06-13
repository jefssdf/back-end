using AgendaApi.Domain.Entities;
using System.Linq.Expressions;

namespace AgendaApi.Domain.Interfaces
{
    public interface ITimetableRepository : IBaseRepository<Timetable>
    {
        Task<IEnumerable<Timetable>> Delete(CancellationToken cancellationToken);
        Task<IEnumerable<Timetable>> GetAllById(Expression<Func<Timetable, bool>> predicate, CancellationToken cancellationToken);
    }
}
