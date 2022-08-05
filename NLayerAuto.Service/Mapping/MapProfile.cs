using AutoMapper;
using NLayerAuto.Core.DTOs;
using NLayerAuto.Core.Model;
namespace NLayerAuto.Service.Mapping;
public class MapProfile:Profile
{
    public MapProfile()
    {
        CreateMap<Cars, CarsDto>().ReverseMap();
        CreateMap<Cars, Cars2Dto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CategoryUpdateDto>().ReverseMap();
        CreateMap<CarsFeature, CarsFeatureDto>().ReverseMap();
        CreateMap<CarsFeature, CarsFeatureDto2>().ReverseMap();
        CreateMap<CarsUpdateDto, Cars>();
        CreateMap<Cars, CarsWithCategoryDto>();
        CreateMap<Category, CategoryWithCarsDto>();
        CreateMap<CarsFeature, CarsFeatureDto>();
        CreateMap<CarsFeature, CarsFeatureDto2>();
    }
}