using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;

namespace NLayerAuto.Core.Services;

public interface ICarsService:IService<Cars>
{
    Task<CustomResponseDto<List<CarsWithCategoryDto>>> GetCarsWithCategory();
}