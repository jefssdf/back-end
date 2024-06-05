using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace AgendaApi.Persistence.Repositories
{
    public class CancellationRepository : BaseRepository<Cancellation>, ICancellationRepository
    {
        public CancellationRepository(AgendaApiDbContext context) : base(context) { }
        public async Task<IEnumerable<Cancellation>> GetAllByOwner(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Cancellations.Where(c => c.Owner == id).ToListAsync(cancellationToken);
        }
    }
}
