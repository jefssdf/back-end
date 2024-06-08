namespace AgendaApi.Application.UseCases.LegalPersonUseCases.DTOs
{
    public abstract record LegalEntityBaseReponse
    {
        public Guid LegalEntityId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
