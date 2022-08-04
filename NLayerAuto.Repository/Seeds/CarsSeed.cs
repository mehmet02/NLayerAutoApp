using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerAuto.Core.Model;

namespace NLayerAuto.Repository.Seeds;

public class CarsSeed : IEntityTypeConfiguration<Cars>
{
    public void Configure(EntityTypeBuilder<Cars> builder)
    {
        builder.HasData(new Cars
        {
            Id = 1,
            CategoryId = 1,
            Name = "Mercedes",
            CreatedDate = DateTime.Now
        },
            new Cars
            {
                Id = 2,
                CategoryId = 1,
                Name = "BMW",
                CreatedDate = DateTime.Now
            },
            new Cars
            {
                Id = 3,
                CategoryId = 1,
                Name = "AUDI",
                CreatedDate = DateTime.Now
            },
            new Cars
            {
                Id = 4,
                CategoryId = 2,
                Name = "Abacus",
                CreatedDate = DateTime.Now
            },
            new Cars
            {
                Id = 5,
                CategoryId = 2,
                Name = "Absolute",
                CreatedDate = DateTime.Now
            },
            new Cars
            {
                Id = 6,
                CategoryId = 2,
                Name = "Admiral Boats",
                CreatedDate = DateTime.Now
            },
            new Cars
            {
                Id = 7,
                CategoryId = 3,
                Name = "MAN",
                CreatedDate = DateTime.Now
            },
            new Cars
            {
                Id = 8,
                CategoryId = 2,
                Name = "DAF",
                CreatedDate = DateTime.Now
            },
            new Cars
            {
                Id = 9,
                CategoryId = 2,
                Name = "ISUZU",
                CreatedDate = DateTime.Now
            });
    }
}