namespace NLayerAuto.Core.DTOs;

public class CarsFeatureIdDto:BaseDto
{
    public int Id { get; set; }
    public string Color { get; set; }
    public bool Headlights { get; set; }
    public int Wheels { get; set; }
    public int CarsId { get; set; }
}