using CateringOrders.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CateringOrders.Data.Repositories.Implementations;

public class FoodCategoryRepository : IFoodCategoryRepository
{
    private readonly ApplicationDbContext _context;

    public FoodCategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<FoodCategory>> GetAll()
    {
        var result = await _context.FoodCategory.ToListAsync();
        return result;
    }
}
