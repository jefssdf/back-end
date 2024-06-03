namespace AgendaApi.Domain.Entities
{
    public class LegalEntity : Person
    {
        public Guid LegalEntityId { get; set; }
        public string? Cnpj { get; set; }
        public string? SocialName { get; set; }
        public string? Address { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Timetable> Timetables { get; set; }
        public ICollection<Scheduling> Schedulings { get; set; }
    }


}
