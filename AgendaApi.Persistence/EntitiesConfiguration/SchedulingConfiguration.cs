﻿using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class SchedulingConfiguration : IEntityTypeConfiguration<Scheduling>
    {
        public void Configure(EntityTypeBuilder<Scheduling> builder)
        {
            builder.HasKey(s => s.SchedulingId);
            builder.Property(s => s.SolicitationDate)
                .HasColumnType("datetime2").HasPrecision(0)
                .IsRequired();
            builder.Property(s => s.ConfirmationDate)
                .HasColumnType("datetime2").HasPrecision(0);
            builder.Property(s => s.SchedulingDate)
                .HasColumnType("datetime2").HasPrecision(0)
                .IsRequired();
            builder.HasOne(s => s.SchedulingStatus)
                .WithMany(ss => ss.Schedulings)
                .HasForeignKey(s => s.SchedulingStatusId);
            builder.HasOne(s => s.NaturalPerson)
                .WithMany(np => np.Schedulings)
                .HasForeignKey(s => s.NaturalPersonId);
            builder.HasOne(s => s.LegalEntity)
                .WithMany(le => le.Schedulings)
                .HasForeignKey(s => s.LegalEntityId);
            builder.HasOne(s => s.Service)
                .WithMany(s => s.Schedulings)
                .HasForeignKey(s => s.ServiceId);
            builder.HasOne(s => s.Cancellation)
                .WithOne(c => c.Scheduling)
                .HasForeignKey<Cancellation>(c => c.SchedulingId);
        }
    }
}
