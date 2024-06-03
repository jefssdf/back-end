using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(s => s.ServiceId);
            builder.Property(s => s.Name).HasMaxLength(70);
            builder.Property(s => s.Description).HasMaxLength(100);
            builder.Property(s => s.Duration)
                .HasColumnType("time").HasPrecision(0).IsRequired();
            builder.Property(s => s.Price).HasColumnType("decimal(10, 2)");
            builder.HasOne(s => s.LegalEntity)
                .WithMany(le => le.Services)
                .HasForeignKey(s => s.LegalEntityId);
            builder.HasOne(s => s.Scheduling)
                .WithOne(s => s.Service)
                .HasForeignKey<Scheduling>(s => s.ServiceId);
        }
    }
}
