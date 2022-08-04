using AutoMapper;
using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;
using NLayerAuto.Core.Repositories;
using NLayerAuto.Core.Services;
using NLayerAuto.Core.UnitOfWorks;

namespace NLayerAuto.Service.Services;

public class CarsService:Service<Cars>,ICarsService
{
    private readonly ICarsRepository _productRepository;
    private readonly IMapper _mapper;
    public CarsService(IGenericRepository<Cars> repository, IUnitOfWork unitOfWork, ICarsRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<CustomResponseDto<List<CarsWithCategoryDto>>> GetCarsWithCategory()
    {
        var products = await _productRepository.GetCarsWithCategory();
        var productsDto=_mapper.Map<List<CarsWithCategoryDto>>(products);
        return CustomResponseDto<List<CarsWithCategoryDto>>.Success(200,productsDto);
    }
}