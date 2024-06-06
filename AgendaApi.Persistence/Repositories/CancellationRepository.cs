using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq.Expressions;

namespace AgendaApi.Persistence.Repositories
{
    public class CancellationRepository : BaseRepository<Cancellation>, ICancellationRepository
    {
        public CancellationRepository(AgendaApiDbContext context) : base(context) { }
        public async Task<IEnumerable<Cancellation>> GetAllByOwner(Expression<Func<Cancellation, bool>> predicate, CancellationToken cancellationToken)
        {
            return await Context.Cancellations.Where(predicate).ToListAsync(cancellationToken);
        }
    }
}
