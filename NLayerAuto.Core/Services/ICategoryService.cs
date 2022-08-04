using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;

namespace NLayerAuto.Core.Services;

public interface ICategoryService:IService<Category>
{
    public Task<CustomResponseDto<CategoryWithCarsDto>> GetSingleCategoryByIdWithCarsAsync(int categoryid);
}