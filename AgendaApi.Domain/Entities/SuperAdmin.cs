namespace AgendaApi.Domain.Entities
{
    public class SuperAdmin
    {
        public Guid SuperAdminId { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
