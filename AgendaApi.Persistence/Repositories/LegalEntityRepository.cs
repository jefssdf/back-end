using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class LegalEntityRepository : BaseRepository<LegalEntity>, ILegalEntityRepository
    {
        public LegalEntityRepository(AgendaApiDbContext context) : base(context) { }

        public async Task<LegalEntity> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.LegalEntities.FirstOrDefaultAsync(lp => lp.Email == email, cancellationToken);
        }
    }
}
