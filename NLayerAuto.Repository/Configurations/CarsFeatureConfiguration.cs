using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerAuto.Core.Model;

namespace NLayerAuto.Repository.Configurations;

public class CarsFeatureConfiguration: IEntityTypeConfiguration<CarsFeature>
{
    public void Configure(EntityTypeBuilder<CarsFeature> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.HasOne(x => x.Cars).WithOne(x => x.CarsFeature).HasForeignKey<CarsFeature>(x => x.CarsId);
    }
}