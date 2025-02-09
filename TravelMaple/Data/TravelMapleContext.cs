using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelMaple.Configurations.Entities;
using TravelMaple.Data;
using TravelMaple.Domain;

namespace TravelMaple.Data
{
    public class TravelMapleContext(DbContextOptions<TravelMapleContext> options) : IdentityDbContext<TravelMapleUserReal>(options)
    {
        public DbSet<TravelMaple.Domain.TravelMapleUser> TravelMapleUser { get; set; } = default!;
        public DbSet<TravelMaple.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<TravelMaple.Domain.Trip> Trip { get; set; } = default!;
        public DbSet<TravelMaple.Domain.ItineraryDay> ItineraryDay { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
        public DbSet<TravelMaple.Domain.Feedback> Feedback { get; set; } = default!;
    }
}

