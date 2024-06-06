namespace AgendaApi.Domain.Entities
{
    public class SchedulingStatus
    {
        public int SchedulingStatusId { get; set; }
        public string StatusName { get; set; }
        public Scheduling Scheduling { get; set; }
    }
}
