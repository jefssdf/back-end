using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Person
    {
        protected readonly AgendaApiDbContext Context;
        public BaseRepository(AgendaApiDbContext context)
        {
            Context = context;
        }
        public void Create(T entity)
        {
            Context.Add(entity);
        }
        public void Update(T entity)
        {
            Context.Update(entity);
        }

        public void Delete(T entity)
        {
            Context.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
        {
            return await Context.Set<T>().ToListAsync(cancellationToken);
        }

        public async Task<T> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(p => p.Id == id ,cancellationToken);
        }

    }
}
