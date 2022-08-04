using NLayerAuto.Core.Model;

namespace NLayerAuto.Core.Repositories;

public interface ICarsRepository:IGenericRepository<Cars>
{
    Task<List<Cars>> GetCarsWithCategory();
}