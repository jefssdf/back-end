namespace AgendaApi.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ILegalEntityRepository LegalEntityRepository { get; }
        INaturalPersonRepository NaturalPersonRepository { get; }
        IServiceCategoryRepository ServiceCategoryRepository { get; }
        IServiceRepository ServiceRepository { get; }
        Task Commit(CancellationToken cancellationToken);
        Task Dispose();
    }
}
