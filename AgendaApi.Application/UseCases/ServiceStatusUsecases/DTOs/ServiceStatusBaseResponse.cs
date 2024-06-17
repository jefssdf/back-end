namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.DTOs
{
    public abstract record ServiceStatusBaseResponse
    {
        public int ServiceStatusId { get; set; }
        public string? StatusName { get; set; }
    }
}
