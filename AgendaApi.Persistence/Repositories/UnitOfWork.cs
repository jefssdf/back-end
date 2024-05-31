using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;

namespace AgendaApi.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ILegalEntityRepository _legalEntityRepository;
        private readonly INaturalPersonRepository _naturalPersonRepository;
        private readonly IServiceCategoryRepository _serviceCategoryRepository;
        private readonly IServiceRepository _serviceRepository;
        private readonly AgendaApiDbContext _context;
        public UnitOfWork(AgendaApiDbContext context)
        {
            _context = context;
        }

        public ILegalEntityRepository LegalEntityRepository =>
            _legalEntityRepository ?? new LegalEntityRepository(_context);
        public INaturalPersonRepository NaturalPersonRepository =>
            _naturalPersonRepository ?? new NaturalPersonRepository(_context);
        public IServiceCategoryRepository ServiceCategoryRepository =>
            _serviceCategoryRepository ?? new ServiceCategoryRepository(_context);
        public IServiceRepository ServiceRepository =>
            _serviceRepository ?? new ServiceRepository(_context);

        public async Task Commit(CancellationToken canellationToken)
        {
            await _context.SaveChangesAsync(canellationToken);
        }

        public async Task Dispose()
        {
            await _context.DisposeAsync();
        }
    }
}
