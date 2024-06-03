namespace AgendaApi.Domain.Entities
{
    public class ServiceCategory
    {
        public Guid ServiceCategoryId { get; set; }
        public string? Name { get; set; }
        public ICollection<Service>? Services { get; set; }
    }
}
