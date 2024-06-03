using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Context
{
    public class AgendaApiDbContext : DbContext
    {
        public AgendaApiDbContext(DbContextOptions<AgendaApiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DbSet<NaturalPerson> NaturalPersons { get; set; }
        public DbSet<LegalEntity> LegalEntities { get; set; }
        public DbSet<SuperAdmin> SuperAdmins { get; set; }
        //public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<SchedulingStatus> SchedulingStatus { get; set; }
        public DbSet<Scheduling> Schedulings { get; set; }
        public DbSet<Cancellation> Cancellations { get; set; }
    }
}
