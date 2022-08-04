using NLayerAuto.Core.Model;
namespace NLayerAuto.Core.Repositories;

public interface ICategoryRepository:IGenericRepository<Category>
{
    Task<Category> GetSingleCategoryByIdWithCarsAsync(int categoryid);
}