using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerAuto.Core.Model;

namespace NLayerAuto.Repository.Seeds;

public class CategorySeed: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category { Id = 1, Name = "Car" }, 
            new Category { Id = 2, Name = "Boats" },
            new Category { Id = 3, Name = "Buses" });
    }
}