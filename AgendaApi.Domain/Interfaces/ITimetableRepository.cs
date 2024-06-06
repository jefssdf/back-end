using AgendaApi.Domain.Entities;
using System.Linq.Expressions;

namespace AgendaApi.Domain.Interfaces
{
    public interface ITimetableRepository : IBaseRepository<Timetable>
    {
        Task<IEnumerable<Timetable>> Delete(CancellationToken cancellationToken);
        Task<Timetable> GetByWeekDayId(Expression<Func<Timetable, bool>> predicate, CancellationToken cancellationToken);
    }
}
