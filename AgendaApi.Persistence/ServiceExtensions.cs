using AgendaApi.Domain.Interfaces;
using AgendaApi.Persistence.Context;
using AgendaApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaApi.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services,
            IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AgendaApiDbContext>(options =>
             options.UseSqlServer(connectionString, sqlOptions =>
             {
                 sqlOptions.MigrationsAssembly("AgendaApi.Persistence");
             }));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<INaturalPersonRepository, NaturalPersonRepository>();
            services.AddScoped<ILegalEntityRepository, LegalEntityRepository>();
        }
    }
}
