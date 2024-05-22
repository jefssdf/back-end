namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.DTOs
{
    public abstract record NaturalPersonBaseResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Cpf { get; set; }
        public DateTimeOffset BirthDate { get; set; }
    }
}
