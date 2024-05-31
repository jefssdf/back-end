using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Domain.Entities
{
    public class LegalEntity : Person
    {
        [Key]
        public Guid LegalEntityId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 14)]
        public string? Cnpj { get; set; }
        [Required]
        [StringLength(70)]
        public string? SocialName { get; set; }
    }


}
