using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AgendaApi.Persistence.Repositories
{
    public class WeekDayRepository : BaseRepository<WeekDay>, IWeekDayRepository
    {
        public WeekDayRepository(AgendaApiDbContext context) : base(context) { }
        public override async Task<WeekDay> GetById(Expression<Func<WeekDay, bool>> predicate, CancellationToken cancellationToken)
        {
            return await Context.WeekDays.Include(wd => wd.Timetables).ThenInclude(tt => tt.Schedulings).FirstOrDefaultAsync(predicate, cancellationToken);
        }
        public override async Task<IEnumerable<WeekDay>> GetAll(CancellationToken cancellationToken)
        {
            return await Context.WeekDays.Include(wd => wd.Timetables).ToListAsync(cancellationToken);
        }
    }
}
