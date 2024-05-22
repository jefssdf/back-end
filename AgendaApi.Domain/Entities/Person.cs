using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Domain.Entities
{
    public abstract class Person
    {
        [Required]
        [StringLength(70)]
        public string? Name { get; set; }
        [Required]
        [StringLength(70)]
        public string? Email { get; set; }
        [Required]
        [StringLength(30)]
        public string? Password { get; set; }
        [Required]
        [StringLength(15)]
        public string? PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string? Address { get; set; }
    }
}
