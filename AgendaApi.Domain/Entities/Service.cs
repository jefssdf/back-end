using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaApi.Domain.Entities
{
    public class Service
    {
        [Key]
        public Guid ServiceId { get; set; }
        [Required]
        [StringLength(70)]
        public string? Name { get; set; }
        [Required]
        [StringLength(150)]
        public string? Description { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [ForeignKey("Id")]
        public LegalEntity? LegalEntity { get; set; }
        [Required]
        [ForeignKey("Id")]
        public ServiceCategory? ServiceCategory { get; set; }
    }
}
