using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class NaturalPersonConfiguration : IEntityTypeConfiguration<NaturalPerson>
    {
        public void Configure(EntityTypeBuilder<NaturalPerson> builder)
        {
            builder.HasKey(np => np.NaturalPersonId);
            builder.Property(np => np.Name).HasMaxLength(70).IsRequired();
            builder.Property(np => np.Email).HasMaxLength(70).IsRequired();
            builder.Property(np => np.Password).HasMaxLength(100).IsRequired();
            builder.Property(np => np.PhoneNumber).HasMaxLength(11)
                .HasAnnotation("RegularExpression",
                "^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[0-9])[0-9]{3}\\-?[0-9]{4}$").IsRequired();
            builder.HasMany(np => np.Schedulings)
                .WithOne(s => s.NaturalPerson)
                .HasForeignKey(s => s.NaturalPersonId);
            builder.HasData(new NaturalPerson
            {
                NaturalPersonId = Guid.NewGuid(),
                Name = "Bloqueio",
                Email = "bloqueio@bloqueio.com",
                Password = "********",
                PhoneNumber = "27999999999",
                CreatedAt = DateTime.Now
            });
        }
    }
}