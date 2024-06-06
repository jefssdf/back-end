using AgendaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Persistence.EntitiesConfiguration
{
    public class SuperAdminConfiguration : IEntityTypeConfiguration<SuperAdmin>
    {
        public void Configure(EntityTypeBuilder<SuperAdmin> builder)
        {
            builder.HasKey(np => np.SuperAdminId);
            builder.Property(np => np.Email).HasMaxLength(70).IsRequired();
            builder.Property(np => np.Password).HasMaxLength(30).IsRequired();
        }
    }
}
