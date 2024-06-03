using AgendaApi.Domain.Entities;
using System.Linq.Expressions;

namespace AgendaApi.Domain.Interfaces
{
    public interface IWeekDayRepository : IBaseRepository<WeekDay>
    {
        new Task<WeekDay> GetById(Expression<Func<WeekDay, bool>> predicate, CancellationToken cancellationToken);
    }
}
