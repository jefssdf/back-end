using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AgendaApi.Persistence.Repositories
{
    public class SchedulingRepository : BaseRepository<Scheduling>,
        ISchedulingRepository
    {
        public SchedulingRepository(AgendaApiDbContext context) : base(context) { }

        public async Task<IEnumerable<Scheduling>> GetAllSchedulingsByTimetableId(Expression<Func<Scheduling, bool>> predicate, CancellationToken cancellationToken)
        {
            return await Context.Schedulings.Where(predicate).ToListAsync(cancellationToken);
        }
    }
}
