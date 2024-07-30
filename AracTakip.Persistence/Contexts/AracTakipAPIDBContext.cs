using AracTakip.Domain.Entities;
using AracTakip.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AracTakip.Persistence.Contexts
{
    public class AracTakipAPIDBContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AracTakipAPIDBContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarEngineType> CarEngineTypes { get; set; }
        public DbSet<CarImageFile> CarImageFiles { get; set; }
        public DbSet<CarReservation> CarReservations { get; set; }
        public DbSet<CarReservationUser> CarReservationUsers { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<UserImageFile> UserImageFiles { get; set; }
    }
}
