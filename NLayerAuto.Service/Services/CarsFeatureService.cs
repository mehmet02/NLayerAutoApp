using NLayerAuto.Core.Model;
using NLayerAuto.Core.Repositories;
using NLayerAuto.Core.Services;
using NLayerAuto.Core.UnitOfWorks;

namespace NLayerAuto.Service.Services;

public class CarsFeatureService : Service<CarsFeature>, ICarsFeatureService
{
    public CarsFeatureService(IGenericRepository<CarsFeature> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}