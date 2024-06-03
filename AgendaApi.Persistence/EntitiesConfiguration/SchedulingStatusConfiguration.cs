using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class SchedulingStatusConfiguration : IEntityTypeConfiguration<SchedulingStatus>
    {
        public void Configure(EntityTypeBuilder<SchedulingStatus> builder)
        {
            builder.HasKey(ss => ss.SchedulingStatusId);
            builder.Property(ss => ss.StatusName)
                .HasMaxLength(20).IsRequired();
            builder.HasOne(ss => ss.Scheduling)
                .WithOne(s => s.SchedulingStatus)
                .HasForeignKey<Scheduling>(s => s.SchedulingStatusId);
        }
    }
}
