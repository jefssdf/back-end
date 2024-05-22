using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class ServiceCategoryRepository : IServiceCategoryRepository
    {
        private readonly AgendaApiDbContext _dbContext;
        public ServiceCategoryRepository(AgendaApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(ServiceCategory entity)
        {
            _dbContext.Add(entity);
        }
        public void Update(ServiceCategory entity)
        {
            _dbContext.Update(entity);
        }

        public void Delete(ServiceCategory entity)
        {
            _dbContext.Remove(entity);
        }

        public async Task<IEnumerable<ServiceCategory>> GetAll(CancellationToken cancellationToken)
        {
            return await _dbContext.ServiceCategories.AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<ServiceCategory> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.ServiceCategories.AsNoTracking().FirstOrDefaultAsync(sc => sc.ServiceCategoryId == id, cancellationToken);
        }

    }
}
