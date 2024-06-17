using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;

namespace AgendaApi.Persistence.Repositories
{
    public class ServiceStatusRepository : BaseRepository<ServiceStatus>, IServiceStatusRepository
    {
        public ServiceStatusRepository(AgendaApiDbContext dbContext) : base(dbContext) { }
    }
}
