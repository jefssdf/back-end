using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class TimetableRepository : BaseRepository<Timetable>, ITimetableRepository
    {
        public TimetableRepository(AgendaApiDbContext context) : base(context) { }
        public async Task<IEnumerable<Timetable>> Delete(CancellationToken cancellationToken)
        {
            var timetables = await Context.Timetables.ToListAsync();
            Context.Timetables.RemoveRange(timetables);
            return timetables;
        }
    }
}
