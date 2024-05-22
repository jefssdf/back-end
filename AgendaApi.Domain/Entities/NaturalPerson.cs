using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Domain.Entities
{
    public class NaturalPerson : Person
    {
        [Key]
        public Guid NaturalPersonId { get; set; }
        [Required]
        [StringLength(15)]
        public string? Cpf { get; set; }
        [Required]
        public DateTimeOffset BirthDate { get; set; }
    }
}
