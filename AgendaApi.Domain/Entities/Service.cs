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
        //[Required]
        //public TimeSpan Duration { get; set; }
        [Required]
        [Column(TypeName ="decimal(20,2)")]
        public decimal Price { get; set; }
        [Required]
        [ForeignKey("LegalEntityId")]
        public Guid? LegalEntityId { get; set; }
        public LegalEntity? LegalEntity { get; set; }
        //[Required]
        //[ForeignKey("ServiceCategoryId")]
        //public Guid? ServiceCategoryId { get; set; }
        //public ServiceCategory? ServiceCategory { get; set; }
    }
}
