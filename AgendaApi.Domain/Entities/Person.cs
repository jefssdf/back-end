namespace AgendaApi.Domain.Entities
{
    public abstract class Person : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
