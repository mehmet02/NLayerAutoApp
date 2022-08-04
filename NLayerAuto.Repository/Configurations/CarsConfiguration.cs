using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerAuto.Core.Model;

namespace NLayerAuto.Repository.Configurations;

public class CarsConfiguration:IEntityTypeConfiguration<Cars>
{
    public void Configure(EntityTypeBuilder<Cars> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.ToTable("Cars");
        builder.HasOne(x=>x.Category).WithMany(x=>x.Cars).HasForeignKey(x=>x.CategoryId);
    }
}