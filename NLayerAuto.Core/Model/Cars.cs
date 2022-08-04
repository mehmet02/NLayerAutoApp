namespace NLayerAuto.Core.Model;

public class Cars : BaseEntity
{
    public string? Name { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public CarsFeature? CarsFeature { get; set; }
}