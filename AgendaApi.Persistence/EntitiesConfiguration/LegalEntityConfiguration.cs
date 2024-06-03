﻿using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class LegalEntityConfiguration : IEntityTypeConfiguration<LegalEntity>
    {
        public void Configure(EntityTypeBuilder<LegalEntity> builder)
        {
            builder.HasKey(le => le.LegalEntityId);
            builder.Property(le => le.Name).HasMaxLength(70).IsRequired();
            builder.Property(le => le.Password).HasMaxLength(30).IsRequired();
            builder.Property(le => le.PhoneNumber).HasMaxLength(11)
                .HasAnnotation("RegularExpression", 
                "^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[0-9])[0-9]{3}\\-?[0-9]{4}$").IsRequired();
            builder.Property(le => le.Address).HasMaxLength(100);
            builder.Property(le => le.Cnpj).HasMaxLength(20)
                .HasAnnotation("RegularExpression", "\\d{2}\\.?\\d{3}\\.?\\d{3}\\/?\\d{4}\\-?\\d{2}\\")
                .IsRequired();
            builder.Property(le => le.SocialName).HasMaxLength(70).IsRequired();
            builder.HasMany(le => le.Services)
                .WithOne(s => s.LegalEntity)
                .HasForeignKey(s => s.LegalEntityId);
            builder.HasMany(le => le.Timetables)
                .WithOne(tt => tt.LegalEntity)
                .HasForeignKey(tt => tt.LegalEntityId);
            builder.HasMany(le => le.Schedulings)
                .WithOne(s => s.LegalEntity)
                .HasForeignKey(s => s.LegalEntityId);
        }   
    }
}
