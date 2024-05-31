using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;

namespace AgendaApi.Persistence.Repositories
{
    public class ServiceCategoryRepository : BaseRepository<ServiceCategory>, IServiceCategoryRepository
    {
        public ServiceCategoryRepository(AgendaApiDbContext context) : base(context) { }
    }
}
