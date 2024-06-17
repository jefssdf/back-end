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
        }
    }
}
