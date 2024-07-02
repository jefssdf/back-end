namespace AgendaApi.Application.UseCases.SuperAdminUseCases.DTOs
{
    public abstract record SuperAdminBaseResponse
    {
        public Guid SuperAdminId { get; set; }
        public string? Email { get; set; }
    }
}
