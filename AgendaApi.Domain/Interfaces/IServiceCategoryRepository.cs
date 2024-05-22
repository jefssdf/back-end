using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface IServiceCategoryRepository : IBaseRepository<ServiceCategory>
    {
        Task<ServiceCategory> GetById(Guid id, CancellationToken cancellationToken);
    }
}
