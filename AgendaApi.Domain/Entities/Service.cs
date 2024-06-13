namespace AgendaApi.Domain.Entities
{
    public class Service
    {
        public Guid ServiceId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Price { get; set; }
        public Guid? LegalEntityId { get; set; }
        public LegalEntity? LegalEntity { get; set; }
        public ICollection<Scheduling> Schedulings { get; set; }
    }
}
