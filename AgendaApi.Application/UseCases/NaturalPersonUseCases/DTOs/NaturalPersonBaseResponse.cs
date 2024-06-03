namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.DTOs
{
    public abstract record NaturalPersonBaseResponse
    {
        public Guid NaturalPersonId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
