﻿// <auto-generated />
using System;
using AgendaApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendaApi.Persistence.Migrations
{
    [DbContext(typeof(AgendaApiDbContext))]
    partial class AgendaApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgendaApi.Domain.Entities.Cancellation", b =>
                {
                    b.Property<Guid>("CancellationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CancellationTime")
                        .HasPrecision(0)
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Owner")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SchedulingId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CancellationId");

                    b.HasIndex("SchedulingId")
                        .IsUnique();

                    b.ToTable("Cancellations");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.LegalEntity", b =>
                {
                    b.Property<Guid>("LegalEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasAnnotation("RegularExpression", "^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[0-9])[0-9]{3}\\-?[0-9]{4}$");

                    b.HasKey("LegalEntityId");

                    b.ToTable("LegalEntities");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.NaturalPerson", b =>
                {
                    b.Property<Guid>("NaturalPersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasAnnotation("RegularExpression", "^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[0-9])[0-9]{3}\\-?[0-9]{4}$");

                    b.HasKey("NaturalPersonId");

                    b.ToTable("NaturalPersons");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Scheduling", b =>
                {
                    b.Property<Guid>("SchedulingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ConfirmationDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LegalEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NaturalPersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SchedulingDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2");

                    b.Property<int>("SchedulingStatusId")
                        .HasColumnType("int");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SolicitationDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2");

                    b.HasKey("SchedulingId");

                    b.HasIndex("LegalEntityId");

                    b.HasIndex("NaturalPersonId");

                    b.HasIndex("SchedulingStatusId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Schedulings");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.SchedulingStatus", b =>
                {
                    b.Property<int>("SchedulingStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchedulingStatusId"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SchedulingStatusId");

                    b.ToTable("SchedulingStatus");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Service", b =>
                {
                    b.Property<Guid>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<TimeSpan>("Duration")
                        .HasPrecision(0)
                        .HasColumnType("time");

                    b.Property<Guid?>("LegalEntityId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ServiceId");

                    b.HasIndex("LegalEntityId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.SuperAdmin", b =>
                {
                    b.Property<Guid>("SuperAdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("SuperAdminId");

                    b.ToTable("SuperAdmins");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Timetable", b =>
                {
                    b.Property<Guid>("TimetableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeOnly>("EndTime")
                        .HasPrecision(0)
                        .HasColumnType("time");

                    b.Property<Guid>("LegalEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeOnly>("StartTime")
                        .HasPrecision(0)
                        .HasColumnType("time");

                    b.Property<int>("WeekDayId")
                        .HasColumnType("int");

                    b.HasKey("TimetableId");

                    b.HasIndex("LegalEntityId");

                    b.HasIndex("WeekDayId");

                    b.ToTable("Timetables");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.WeekDay", b =>
                {
                    b.Property<int>("WeekDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeekDayId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("WeekDayId");

                    b.ToTable("WeekDays");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Cancellation", b =>
                {
                    b.HasOne("AgendaApi.Domain.Entities.Scheduling", "Scheduling")
                        .WithOne("Cancellation")
                        .HasForeignKey("AgendaApi.Domain.Entities.Cancellation", "SchedulingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scheduling");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Scheduling", b =>
                {
                    b.HasOne("AgendaApi.Domain.Entities.LegalEntity", "LegalEntity")
                        .WithMany("Schedulings")
                        .HasForeignKey("LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgendaApi.Domain.Entities.NaturalPerson", "NaturalPerson")
                        .WithMany("Schedulings")
                        .HasForeignKey("NaturalPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgendaApi.Domain.Entities.SchedulingStatus", "SchedulingStatus")
                        .WithMany("Schedulings")
                        .HasForeignKey("SchedulingStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgendaApi.Domain.Entities.Service", "Service")
                        .WithMany("Schedulings")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LegalEntity");

                    b.Navigation("NaturalPerson");

                    b.Navigation("SchedulingStatus");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Service", b =>
                {
                    b.HasOne("AgendaApi.Domain.Entities.LegalEntity", "LegalEntity")
                        .WithMany("Services")
                        .HasForeignKey("LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LegalEntity");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Timetable", b =>
                {
                    b.HasOne("AgendaApi.Domain.Entities.LegalEntity", "LegalEntity")
                        .WithMany("Timetables")
                        .HasForeignKey("LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgendaApi.Domain.Entities.WeekDay", "WeekDay")
                        .WithMany("Timetables")
                        .HasForeignKey("WeekDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LegalEntity");

                    b.Navigation("WeekDay");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.LegalEntity", b =>
                {
                    b.Navigation("Schedulings");

                    b.Navigation("Services");

                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.NaturalPerson", b =>
                {
                    b.Navigation("Schedulings");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Scheduling", b =>
                {
                    b.Navigation("Cancellation")
                        .IsRequired();
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.SchedulingStatus", b =>
                {
                    b.Navigation("Schedulings");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.Service", b =>
                {
                    b.Navigation("Schedulings");
                });

            modelBuilder.Entity("AgendaApi.Domain.Entities.WeekDay", b =>
                {
                    b.Navigation("Timetables");
                });
#pragma warning restore 612, 618
        }
    }
}
