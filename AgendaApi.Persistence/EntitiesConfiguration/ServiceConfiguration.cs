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
            builder.Property(s => s.Name).HasMaxLength(70).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Duration)
                .HasColumnType("time").HasPrecision(0).IsRequired();
            builder.Property(s => s.Price).HasColumnType("decimal(10, 2)");
            builder.Property(s => s.LegalEntityId).IsRequired();
            builder.Property(s => s.ServiceStatusId).IsRequired();
            builder.HasOne(s => s.ServiceStatus).
                WithMany(ss => ss.Services)
                .HasForeignKey(s => s.ServiceStatusId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(s => s.LegalEntity)
                .WithMany(le => le.Services)
                .HasForeignKey(s => s.LegalEntityId);
            builder.HasMany( s => s.Schedulings)
                .WithOne(s => s.Service)
                .HasForeignKey(s => s.ServiceId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}