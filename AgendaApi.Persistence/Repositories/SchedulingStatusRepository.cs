using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;

namespace AgendaApi.Persistence.Repositories
{
    public class SchedulingStatusRepository 
        : BaseRepository<SchedulingStatus>, ISchedulingStatusRepository
    {
        public SchedulingStatusRepository(AgendaApiDbContext context) : base(context) { }
    }
}
