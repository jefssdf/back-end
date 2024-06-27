namespace AgendaApi.Application.UseCases.SchedulingUseCases.DTOs
{
    public abstract record SchedulingBaseResponse
    {
        public Guid SchedulingId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime SchedulingDate { get; set; }
        public int SchedulingStatusId { get; set; }
        public Guid NaturalPersonId { get; set; }
        public Guid LegalEntityId { get; set; }
        public Guid ServiceId { get; set; }
    }
    public abstract record SchedulingWithNaturalPersonInfo
    {
        public Guid schedulingId { get; set; }
        public DateTime schedulingDate { get; set; }
        public Guid legalEntityId { get; set; }
        public string? schedulingStatusName { get; set; }
        public string? serviceName { get; set; }
        public string? serviceDuration { get; set; }
        public string? naturalPersonName { get; set; }
        public string? naturalPersonPhone { get; set; }
    }
    public abstract record SchedulingWithLegalEntityInfo
    {
        public Guid schedulingId { get; set; }
        public DateTime schedulingDate { get; set; }
        public Guid legalEntityId { get; set; }
        public string? schedulingStatusName { get; set; }
        public string? serviceName { get; set; }
        public string? serviceDuration { get; set; }
        public string? legalEntityName { get; set; }
        public string? legalEntityPhone { get; set; }
    }
}
