using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class ServiceRepository<T> : IBaseRepository<T> where T : Service
    {
        private readonly AgendaApiDbContext _dbContext;

        public ServiceRepository(AgendaApiDbContext context)
        { 
            _dbContext = context;
        }

        public void Create(T entity)
        {
            _dbContext.Add(entity);
        }
        public void Update(T entity)
        {
            _dbContext.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
        {
            return await _dbContext.Set<T>().AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<T> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(s => s.ServiceId == id, cancellationToken);
        }

    }
}
