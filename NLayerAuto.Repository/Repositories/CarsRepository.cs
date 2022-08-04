using Microsoft.EntityFrameworkCore;
using NLayerAuto.Core.Model;
using NLayerAuto.Core.Repositories;

namespace NLayerAuto.Repository.Repositories;

public class CarsRepository:GenericRepository<Cars>,ICarsRepository
{
    public CarsRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<Cars>> GetCarsWithCategory()
    {
        return await _context.Products.Include(x=>x.Category).ToListAsync();
    }
}