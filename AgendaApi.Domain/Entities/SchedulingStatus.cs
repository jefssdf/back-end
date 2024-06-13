namespace AgendaApi.Domain.Entities
{
    public class SchedulingStatus
    {
        public int SchedulingStatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<Scheduling> Schedulings { get; set; }
    }
}
