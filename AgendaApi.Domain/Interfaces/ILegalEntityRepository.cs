using AgendaApi.Domain.Entities;

namespace AgendaApi.Domain.Interfaces
{
    public interface ILegalEntityRepository : IBaseRepository<LegalEntity>
    {
        Task<LegalEntity> GetByEmail(string email, CancellationToken cancellationToken);
        Task<LegalEntity> GetById(Guid id, CancellationToken cancellationToken);
    }
}
