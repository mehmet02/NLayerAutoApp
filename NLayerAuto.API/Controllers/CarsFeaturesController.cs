using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerAuto.API.Filters;
using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;
using NLayerAuto.Core.Services;

namespace NLayerAuto.API.Controllers
{
    public class CarsFeaturesController : CustomBaseController
    {
        private readonly ICarsFeatureService _service;
        private readonly IMapper _mapper;

        public CarsFeaturesController(ICarsFeatureService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        //GET api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var carsfeature = await _service.GetAllAsync();
            var carsfeatureDto = _mapper.Map<List<CarsFeatureDto>>(carsfeature.ToList());
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            return CrateActionResult(CustomResponseDto<List<CarsFeatureDto>>.Success(200, carsfeatureDto));
        }
       // [ServiceFilter(typeof(NotFoundFilter<CarsFeature>))] //Id yi Burada Kontrol Ediyor.
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cars = await _service.GetByIdAsync(id);
            var carsDto = _mapper.Map<CarsFeatureDto>(cars);
            return CrateActionResult(CustomResponseDto<CarsFeatureDto>.Success(200, carsDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CarsFeatureDto carsfeatureDto)
        {
            var carsfeature = await _service.AddAsync(_mapper.Map<CarsFeature>(carsfeatureDto));
            var carssFeatureDto = _mapper.Map<CarsFeatureDto>(carsfeature);
            return CrateActionResult(CustomResponseDto<CarsFeatureDto>.Success(201, carssFeatureDto));
        }
        [HttpPut]
        public async Task<IActionResult> Update(CarsFeatureDto carsFeatureDto)
        {
            await _service.UpdateAsync(_mapper.Map<CarsFeature>(carsFeatureDto));
            return CrateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpPut("{id}")]//Aracın Farını Açıp Kapatmak İçin
        public async Task<IActionResult> HeadlightsONOFF(CarsFeatureDto2 carsFeatureDto, int id)
        {
            var product = await _service.GetByIdAsync(id);
            product.Headlights = carsFeatureDto.Headlights;
            await _service.UpdateAsync(_mapper.Map<CarsFeature>(product));
            return CrateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        //[ServiceFilter(typeof(NotFoundFilter<CarsFeature>))] //Id yi Burada Kontrol Ediyor.
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(product);
            return CrateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
