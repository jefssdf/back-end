using AgendaApi.Domain.Entities;
using System.Linq.Expressions;

namespace AgendaApi.Domain.Interfaces
{
    public interface IServiceRepository : IBaseRepository<Service>
    {
        Task<IEnumerable<Service>> GetAllById(Expression<Func<Service, bool>> predicate, CancellationToken cancellationToken);
    }
}
