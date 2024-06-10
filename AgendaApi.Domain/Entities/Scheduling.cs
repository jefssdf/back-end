namespace AgendaApi.Domain.Entities
{
    public class Scheduling
    {
        public Guid SchedulingId { get; set; }
        public DateTime SolicitationDate {  get; set; }
        public DateTime ConfirmationDate { get; set; }
        public DateTime SchedulingDate { get; set; }
        public int SchedulingStatusId { get; set; }
        public SchedulingStatus SchedulingStatus { get; set; }
        public Guid NaturalPersonId { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
        public Guid LegalEntityId { get; set; }
        public LegalEntity LegalEntity { get; set; }
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public Cancellation Cancellation { get; set; }
    }
}
