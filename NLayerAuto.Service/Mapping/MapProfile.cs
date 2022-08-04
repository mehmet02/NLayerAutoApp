using AutoMapper;
using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;
namespace NLayerAuto.Service.Mapping;
public class MapProfile:Profile
{
    public MapProfile()
    {
        CreateMap<Cars, CarsDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<CarsFeature, CarsFeatureDto>().ReverseMap();
        CreateMap<CarsUpdateDto, Cars>();
        CreateMap<Cars, CarsWithCategoryDto>();
        CreateMap<Category, CategoryWithCarsDto>();
    }
}