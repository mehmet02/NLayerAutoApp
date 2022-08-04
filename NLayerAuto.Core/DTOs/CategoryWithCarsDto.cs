namespace NLayerAuto.Core.DTOs;
public class CategoryWithCarsDto:CategoryDto
{
    public List<CarsDto> Cars { get; set; }
}