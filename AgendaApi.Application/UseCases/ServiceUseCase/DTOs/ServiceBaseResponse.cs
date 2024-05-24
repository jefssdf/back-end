namespace AgendaApi.Application.UseCases.ServiceUseCase.DTOs
{
    public abstract record ServiceBaseResponse
    {
        public Guid ServiceId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }       
        public Guid? LegalEntityId { get; set; }   
    }
}
