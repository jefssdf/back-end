using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface ITimetableRepository : IBaseRepository<Timetable>
    {
        Task<IEnumerable<Timetable>> Delete(CancellationToken cancellationToken);
    }
}
