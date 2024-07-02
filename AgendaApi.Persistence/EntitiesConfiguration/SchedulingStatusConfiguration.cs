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
            builder.Property(ss => ss.SchedulingStatusId)
                .ValueGeneratedNever();
            builder.Property(ss => ss.StatusName)
                .HasMaxLength(70).IsRequired();
            builder.HasMany(ss => ss.Schedulings)
                .WithOne(s => s.SchedulingStatus)
                .HasForeignKey(s => s.SchedulingStatusId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasData(new SchedulingStatus { SchedulingStatusId = 1, StatusName = "Agendado", CreatedAt = DateTime.Now },
                new SchedulingStatus { SchedulingStatusId = 2, StatusName = "Finalizado", CreatedAt = DateTime.Now },
                new SchedulingStatus { SchedulingStatusId = 3, StatusName = "Aguardando pagamento", CreatedAt = DateTime.Now },
                new SchedulingStatus { SchedulingStatusId = 4, StatusName = "Cancelado", CreatedAt = DateTime.Now });
        }
    }
}