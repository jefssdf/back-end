namespace AgendaApi.Application.UseCases.SchedulingUseCases.DTOs
{
    public abstract record SchedulingBaseResponse
    {
        public Guid SchedulingId { get; set; }
        public DateTime SolicitationDate { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public DateTime SchedulingDate { get; set; }
        public int SchedulingStatusId { get; set; }
        public Guid NaturalPersonId { get; set; }
        public Guid LegalEntityId { get; set; }
        public Guid ServiceId { get; set; }
    }
}
