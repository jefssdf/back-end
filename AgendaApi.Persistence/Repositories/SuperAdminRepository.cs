using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class SuperAdminRepository : BaseRepository<SuperAdmin>, ISuperAdminRepository
    {
        public SuperAdminRepository(AgendaApiDbContext context) : base(context) { }
        public async Task<SuperAdmin> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.SuperAdmins.AsNoTracking().FirstOrDefaultAsync(sa => sa.Email == email);
        }
    }
}
