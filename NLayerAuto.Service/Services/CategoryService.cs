using AutoMapper;
using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;
using NLayerAuto.Core.Repositories;
using NLayerAuto.Core.Services;
using NLayerAuto.Core.UnitOfWorks;

namespace NLayerAuto.Service.Services;

public class CategoryService:Service<Category>,ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<CustomResponseDto<CategoryWithCarsDto>> GetSingleCategoryByIdWithCarsAsync(int categoryid)
    {
        var category = await _categoryRepository.GetSingleCategoryByIdWithCarsAsync(categoryid);
        var categoryDto=_mapper.Map<CategoryWithCarsDto>(category);
        return CustomResponseDto<CategoryWithCarsDto>.Success(200, categoryDto);
    }
}