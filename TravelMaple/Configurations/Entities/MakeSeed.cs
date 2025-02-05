using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMaple.Domain;

namespace TravelMaple.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
            new Make
            {
                Id = 1,
                Name = "Hotel",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Make
            {
                Id = 2,
                Name = "Resort",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Make
            {
                Id = 3,
                Name = "B&B",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}
