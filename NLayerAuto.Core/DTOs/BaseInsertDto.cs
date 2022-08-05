namespace NLayerAuto.Core.DTOs;

public abstract class BaseInsertDto
{
    public DateTime CreatedDate { get; set; }= DateTime.Now;
}