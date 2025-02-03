using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelMaple.Domain;
using TravelMaple.Configurations.Entities;

namespace TravelMaple.Data
{
    public class TravelMapleContext : DbContext
    {
        public TravelMapleContext (DbContextOptions<TravelMapleContext> options)
            : base(options)
        {
        }
        public DbSet<TravelMaple.Domain.TravelMapleUser> TravelMapleUser { get; set; } = default!;
        public DbSet<TravelMaple.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<TravelMaple.Domain.Trip> Trip { get; set; } = default!;
        public DbSet<TravelMaple.Domain.Make> Make { get; set; } = default!;
        public DbSet<TravelMaple.Domain.Destination> Destination { get; set; } = default!;
        public DbSet<TravelMaple.Domain.TransportMode> TransportMode { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new TransportModeSeed());
            builder.ApplyConfiguration(new DestinationSeed());
        }
    }
}
