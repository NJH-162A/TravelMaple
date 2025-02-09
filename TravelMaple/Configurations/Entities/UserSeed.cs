using TravelMaple.Data;
using TravelMaple.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMaple.Domain;
namespace TravelMaple.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<TravelMapleUser>
    {
        public void Configure(EntityTypeBuilder<TravelMapleUser> builder)
        {
            var hasher = new PasswordHasher<TravelMapleUser>();
            builder.HasData(
            new TravelMapleUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}