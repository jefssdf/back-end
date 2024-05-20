using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Persistence.Context
{
    public class AgendaApiDbContext : DbContext
    {
        public AgendaApiDbContext(DbContextOptions<AgendaApiDbContext> options) : base(options) { }

        public DbSet<NaturalPerson> NaturalPersons { get; set; }
        public DbSet<LegalEntity> LegalEntities { get; set; }
        public DbSet<SuperAdmin> SuperAdmins { get; set; }
    }
}
