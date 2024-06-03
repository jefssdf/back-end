using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class ServiceRepository : BaseRepository<Service>, IServiceRepository
    {
        public ServiceRepository(AgendaApiDbContext context) : base(context) { }
        public async Task<IEnumerable<Service>> GetAllServicesByLegalEntityId(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Services.Where(s => s.LegalEntityId == id).ToListAsync(cancellationToken);
        }
    }
}
