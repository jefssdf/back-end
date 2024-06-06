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
            builder.HasOne(s => s.LegalEntity)
                .WithMany(le => le.Services)
                .HasForeignKey(s => s.LegalEntityId);
            builder.HasOne(s => s.Scheduling)
                .WithOne(s => s.Service)
                .HasForeignKey<Scheduling>(s => s.ServiceId);
        }
    }
}


/*
         public Guid ServiceId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Price { get; set; }
        public Guid? LegalEntityId { get; set; }
        public LegalEntity? LegalEntity { get; set; }
        //public Guid? ServiceCategoryId { get; set; }
        //public ServiceCategory? ServiceCategory { get; set; }
        public Scheduling Scheduling { get; set; }
    }
 */