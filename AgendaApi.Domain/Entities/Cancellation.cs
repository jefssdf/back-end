using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaApi.Domain.Entities
{
    public class Cancellation
    {
        public Guid CancellationId { get; set; }
        public DateTime? CancellationTime { get; set; }
        public Guid Owner {  get; set; }
        public Guid? SchedulingId { get; set; }
        public Scheduling Scheduling { get; set; }
    }
}
