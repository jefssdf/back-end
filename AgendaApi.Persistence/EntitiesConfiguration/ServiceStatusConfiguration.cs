using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class ServiceStatusConfiguration : IEntityTypeConfiguration<ServiceStatus>
    {
        public void Configure(EntityTypeBuilder<ServiceStatus> builder)
        {
            builder.HasKey(ss => ss.ServiceStatusId);
            builder.Property(ss => ss.ServiceStatusId)
                .ValueGeneratedNever();
            builder.Property(ss => ss.StatusName).HasMaxLength(70)
                .IsRequired();
            builder.HasMany(ss => ss.Services)
                .WithOne(s => s.ServiceStatus)
                .HasForeignKey(s => s.ServiceStatusId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
