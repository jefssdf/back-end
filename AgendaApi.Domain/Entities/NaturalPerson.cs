using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Domain.Entities
{
    public sealed class NaturalPerson : Person
    {
        [Required]
        [StringLength(15)]
        public string? Cpf { get; set; }
        [Required]
        public DateTimeOffset BirthDate { get; set; }
    }
}
