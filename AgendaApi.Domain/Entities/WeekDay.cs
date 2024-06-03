namespace AgendaApi.Domain.Entities
{
    public class WeekDay
    {
        public int WeekDayId { get; set; }
        public string Name { get; set; }
        public ICollection<Timetable> Timetables { get; set; }
    }
}
