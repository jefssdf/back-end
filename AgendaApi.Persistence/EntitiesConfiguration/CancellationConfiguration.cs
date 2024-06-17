using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class CancellationConfiguration : IEntityTypeConfiguration<Cancellation>
    {
        public void Configure(EntityTypeBuilder<Cancellation> builder)
        {
            builder.HasKey(c => c.CancellationId);
            builder.Property(c => c.CancellationTime)
                .HasColumnType("datetime2").HasPrecision(0).IsRequired();
            builder.Property(c => c.Owner).IsRequired();
            builder.Property(c => c.SchedulingId).IsRequired();
            builder.HasOne(c => c.Scheduling)
                .WithOne(s => s.Cancellation)
                .HasForeignKey<Cancellation>(c => c.SchedulingId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}