using AracTakip.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace AracTakip.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AracTakipAPIDBContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
