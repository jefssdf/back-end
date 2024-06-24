using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AgendaApi.Persistence.Repositories
{
    public class SchedulingRepository : BaseRepository<Scheduling>,
        ISchedulingRepository
    {
        public SchedulingRepository(AgendaApiDbContext context) : base(context) { }

        public override void Create(Scheduling entity)
        {
            entity.SchedulingStatusId = 1;
            base.Create(entity);
        }

        public override void Update(Scheduling entity)
        {
            Context.Schedulings.Update(entity);
        }

        public async Task<IEnumerable<Scheduling>> GetAllById(Expression<Func<Scheduling, bool>> predicate, CancellationToken cancellationToken)
        {
            return await Context.Schedulings.Where(predicate).ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Scheduling>> GetAllByDate(Expression<Func<Scheduling, bool>> predicate, CancellationToken cancellationToken)
        {
            return await Context.Schedulings.Where(predicate).Include(s => s.Service).Include(s => s.NaturalPerson).ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Scheduling>> GetAllByIdComplete(Expression<Func<Scheduling, bool>> predicate, CancellationToken cancellationToken)
        {
            return await Context.Schedulings.Where(predicate).Include(s => s.NaturalPerson).Include(s => s.Service).ToListAsync(cancellationToken);
        }
    }
}
