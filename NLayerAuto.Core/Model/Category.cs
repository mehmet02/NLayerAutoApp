namespace NLayerAuto.Core.Model;
public class Category : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Cars> Cars { get; set; }
}