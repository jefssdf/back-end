using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface ISuperAdminRepository : IBaseRepository<SuperAdmin>
    {
        Task<SuperAdmin> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
