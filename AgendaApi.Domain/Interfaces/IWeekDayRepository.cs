using AgendaApi.Domain.Entities;
using System.Linq.Expressions;

namespace AgendaApi.Domain.Interfaces
{
    public interface IWeekDayRepository : IBaseRepository<WeekDay>
    {
        Task<IEnumerable<WeekDay>> GetAllById(Guid legalEntityId, CancellationToken cancellationToken);
    }
}
