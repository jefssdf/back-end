using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class WeekDayConfiguration : IEntityTypeConfiguration<WeekDay>
    {
        public void Configure(EntityTypeBuilder<WeekDay> builder)
        {
            builder.HasKey(wd => wd.WeekDayId);
            builder.Property(wd => wd.WeekDayId)
                .ValueGeneratedNever();
            builder.Property(wd => wd.Name).HasMaxLength(20)
                .IsRequired();
            builder.HasMany(wd => wd.Timetables)
                .WithOne(tt => tt.WeekDay)
                .HasForeignKey(tt => tt.WeekDayId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasData(new WeekDay { WeekDayId = 1, Name = "Domingo" },
                new WeekDay { WeekDayId = 2, Name = "Segunda" },
                new WeekDay { WeekDayId = 3, Name = "Terça" },
                new WeekDay { WeekDayId = 4, Name = "Quarta" },
                new WeekDay { WeekDayId = 5, Name = "Quinta" },
                new WeekDay { WeekDayId = 6, Name = "Sexta" },
                new WeekDay { WeekDayId = 7, Name = "Sábado" });
        }
    }
}
