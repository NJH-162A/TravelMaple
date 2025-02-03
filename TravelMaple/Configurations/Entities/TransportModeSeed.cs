using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMaple.Domain;

namespace TravelMaple.Configurations.Entities
{
    public class TransportModeSeed : IEntityTypeConfiguration<TransportMode>
    {
        public void Configure(EntityTypeBuilder<TransportMode> builder)
        {
            builder.HasData(
            new TransportMode
            {
                Id = 1,
                Name = "Air",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new TransportMode
            {
                Id = 2,
                Name = "Land",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new TransportMode
            {
                Id = 3,
                Name = "Sea",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}
