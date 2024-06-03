namespace AgendaApi.Domain.Entities
{
    public class SchedulingStatus
    {
        public Guid SchedulingStatusId { get; set; }
        public string StatusName { get; set; }
        public Scheduling Scheduling { get; set; }
    }
}
