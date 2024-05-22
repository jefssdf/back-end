using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class NaturalPersonRepository : BaseRepository<NaturalPerson>, INaturalPersonRepository
    {
        public NaturalPersonRepository(AgendaApiDbContext context) : base(context) { }

        public async Task<NaturalPerson> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.NaturalPersons.AsNoTracking().FirstOrDefaultAsync(np => np.Email == email);
        }

        public async Task<NaturalPerson> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await Context.NaturalPersons.AsNoTracking().FirstOrDefaultAsync(np => np.NaturalPersonId == id, cancellationToken);
        }
    }
}
