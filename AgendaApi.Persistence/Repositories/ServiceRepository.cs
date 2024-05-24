using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly AgendaApiDbContext _dbContext;

        public ServiceRepository(AgendaApiDbContext context)
        { 
            _dbContext = context;
        }

        public void Create(Service entity)
        {
            _dbContext.Add(entity);
        }
        public void Update(Service entity)
        {
            _dbContext.Update(entity);
        }

        public void Delete(Service entity)
        {
            _dbContext.Remove(entity);
        }

        public async Task<IEnumerable<Service>> GetAll(CancellationToken cancellationToken)
        {
            return await _dbContext.Services.AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<Service> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.Services.AsNoTracking().FirstOrDefaultAsync(s => s.ServiceId == id, cancellationToken);
        }

    }
}
