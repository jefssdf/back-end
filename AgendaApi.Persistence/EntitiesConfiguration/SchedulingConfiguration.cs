using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class SchedulingConfiguration : IEntityTypeConfiguration<Scheduling>
    {
        public void Configure(EntityTypeBuilder<Scheduling> builder)
        {
            builder.HasKey(s => s.SchedulingId);
            builder.Property(s => s.Solicitation)
                .HasColumnType("datetime2").HasPrecision(0)
                .IsRequired();
            builder.Property(s => s.Confirmation)
                .HasColumnType("datetime2").HasPrecision(0)
                .IsRequired();
            builder.Property(s => s.ConfirmedScheduling)
                .HasColumnType("datetime2").HasPrecision(0)
                .IsRequired();
            builder.HasOne(s => s.SchedulingStatus)
                .WithOne(ss => ss.Scheduling)
                .HasForeignKey<Scheduling>(s => s.SchedulingStatusId);
            builder.HasOne(s => s.NaturalPerson)
                .WithMany(np => np.Schedulings)
                .HasForeignKey(s => s.NaturalPersonId);
            builder.HasOne(s => s.LegalEntity)
                .WithMany(le => le.Schedulings)
                .HasForeignKey(s => s.LegalEntityId);
            builder.HasOne(s => s.Service)
                .WithOne(s => s.Scheduling)
                .HasForeignKey<Scheduling>(s => s.ServiceId);
        }
    }
}
