namespace AgendaApi.Domain.Entities
{
    public class SuperAdmin : BaseEntity
    {
        public Guid SuperAdminId { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
