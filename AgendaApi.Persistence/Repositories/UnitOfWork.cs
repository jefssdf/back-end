using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;

namespace AgendaApi.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AgendaApiDbContext _context;
        public UnitOfWork(AgendaApiDbContext context)
        {
            _context = context;
        }
        public async Task Commit(CancellationToken canellationToken)
        {
            await _context.SaveChangesAsync(canellationToken);
        }
    }
}
