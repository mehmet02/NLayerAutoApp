using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerAuto.API.Filters;
using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;
using NLayerAuto.Core.Services;

namespace NLayerAuto.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        // api/categories/GetSingleCategoryByIdWithProductAsync/2
        [HttpGet("[action]")]
        public async Task<IActionResult> GetSingleCategoryByIdWithProductAsync(int categoryid)
        {
            return CrateActionResult(await _categoryService.GetSingleCategoryByIdWithCarsAsync(categoryid));
        }
        //GET api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var category = await _categoryService.GetAllAsync();
            var categoryDto = _mapper.Map<List<CategoryDto>>(category.ToList());
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            return CrateActionResult(CustomResponseDto<List<CategoryDto>>.Success(200, categoryDto));
        }
        [ServiceFilter(typeof(NotFoundFilter<Cars>))] //Id yi Burada Kontrol Ediyor.
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return CrateActionResult(CustomResponseDto<CategoryDto>.Success(200, categoryDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoriesDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoriesDto));
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return CrateActionResult(CustomResponseDto<CategoryDto>.Success(201, categoryDto));
        }
        [HttpPut]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryDto)
        {
            await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryDto));
            return CrateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [ServiceFilter(typeof(NotFoundFilter<Cars>))] //Id yi Burada Kontrol Ediyor.
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            await _categoryService.RemoveAsync(category);
            return CrateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
