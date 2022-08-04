using Microsoft.EntityFrameworkCore;
using NLayerAuto.Core.Model;
using NLayerAuto.Core.Repositories;

namespace NLayerAuto.Repository.Repositories;

public class CategoryRepository:GenericRepository<Category>,ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Category> GetSingleCategoryByIdWithCarsAsync(int categoryid)
    {
        return await _context.Categories.Include(x => x.Cars).Where(x => x.Id == categoryid).SingleOrDefaultAsync();
    }
}