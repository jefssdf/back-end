using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;

namespace AgendaApi.Persistence.Repositories
{
    public class SchedulingRepository : BaseRepository<Scheduling>,
        ISchedulingRepository
    {
        public SchedulingRepository(AgendaApiDbContext context) : base(context) { }
    }
}
