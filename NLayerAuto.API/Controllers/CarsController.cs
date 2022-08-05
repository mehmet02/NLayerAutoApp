using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerAuto.API.Filters;
using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;
using NLayerAuto.Core.Services;

namespace NLayerAuto.API.Controllers
{
    public class CarsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICarsService _service;
        public CarsController(IMapper mapper, ICarsService service)
        {
            _mapper = mapper;
            _service = service;

        }
        //GET api/products/GetProductWithCategory
        [HttpGet("[action]")] //HttGet Metodları Çarpışmasın
        public async Task<IActionResult> GetCarsWithCategory()
        {
            return CrateActionResult(await _service.GetCarsWithCategory());
        }
        //GET api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var cars=await _service.GetAllAsync();
            var carsDto=_mapper.Map<List<CarsDto>>(cars.ToList());
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            return CrateActionResult(CustomResponseDto<List<CarsDto>>.Success(200, carsDto));
        }
        [ServiceFilter(typeof(NotFoundFilter<Cars>))] //Id yi Burada Kontrol Ediyor.
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cars = await _service.GetByIdAsync(id);
            var carsDto = _mapper.Map<CarsDto>(cars);
            return CrateActionResult(CustomResponseDto<CarsDto>.Success(200, carsDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(Cars2Dto carsDto)
        {
            var cars = await _service.AddAsync(_mapper.Map<Cars>(carsDto));
            var carssDto = _mapper.Map<Cars2Dto>(cars);
            return CrateActionResult(CustomResponseDto<Cars2Dto>.Success(201, carssDto));
        }
        [HttpPut]
        public async Task<IActionResult> Update(CarsUpdateDto carsDto)
        {
            await _service.UpdateAsync(_mapper.Map<Cars>(carsDto));
            return CrateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [ServiceFilter(typeof(NotFoundFilter<Cars>))] //Id yi Burada Kontrol Ediyor.
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(product);
            return CrateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}