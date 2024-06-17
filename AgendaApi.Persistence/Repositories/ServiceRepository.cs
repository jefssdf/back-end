using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AgendaApi.Persistence.Repositories
{
    public class ServiceRepository : BaseRepository<Service>, IServiceRepository
    {
        public ServiceRepository(AgendaApiDbContext context) : base(context) { }
        public override void Create(Service entity)
        {
            entity.ServiceStatusId = 1;
            base.Create(entity);
        }
        public async Task<IEnumerable<Service>> GetAllById(Expression<Func<Service, bool>> predicate, CancellationToken cancellationToken)
        {
            return await Context.Services.Where(predicate).ToListAsync(cancellationToken);
        }
    }
}
