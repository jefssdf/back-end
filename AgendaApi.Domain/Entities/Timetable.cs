
namespace AgendaApi.Domain.Entities
{
    public class Timetable
    {
        public Guid TimetableId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public Guid LegalEntityId { get; set; }
        public LegalEntity? LegalEntity { get; set; }
        public int WeekDayId { get; set; }
        public WeekDay? WeekDay { get; set; }
    }
}
