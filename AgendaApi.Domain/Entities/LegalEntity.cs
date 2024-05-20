using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Domain.Entities
{
    public sealed class LegalEntity : Person
    {
        [Required]
        [StringLength(20)]
        public string? Cnpj { get; set; }
        [Required]
        [StringLength(70)]
        public string? SocialName { get; set; }
    }
}
