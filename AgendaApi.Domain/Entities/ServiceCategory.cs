using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AgendaApi.Domain.Entities
{
    public class ServiceCategory
    {
        [Key]
        public Guid ServiceCategoryId { get; set; }
        [Required]
        [StringLength(70)]
        public string? Name { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ICollection<Service>? Services { get; set; }
        public ServiceCategory() { Services = new Collection<Service>(); }
    }
}
