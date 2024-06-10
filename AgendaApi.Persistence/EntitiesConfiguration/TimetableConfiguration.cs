using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class TimetableConfiguration : IEntityTypeConfiguration<Timetable>
    {
        public void Configure(EntityTypeBuilder<Timetable> builder)
        {
            builder.HasKey(tt => tt.TimetableId);
            builder.Property(tt => tt.StartTime)
                .HasColumnType("time").HasPrecision(0).IsRequired();
            builder.Property(tt => tt.EndTime)
                .HasColumnType("time").HasPrecision(0).IsRequired();
            builder.HasOne(tt => tt.LegalEntity)
                .WithMany(le => le.Timetables)
                .HasForeignKey(tt => tt.LegalEntityId);
            builder.HasOne(tt => tt.WeekDay)
                .WithMany(wd => wd.Timetables)
                .HasForeignKey(tt => tt.WeekDayId);
        }
    }
}
