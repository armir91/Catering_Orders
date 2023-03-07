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

    public async Task<List<FoodCategory>> GetAllAsync()
    {
        var result = await _context.FoodCategory.ToListAsync();
        return result;
    }

    public Task<FoodCategory> AddAsync(FoodCategory foodCategory)
    {
        throw new NotImplementedException();
    }

    public Task<FoodCategory> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<FoodCategory> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<FoodCategory> UpdateAsync(FoodCategory foodCategory)
    {
        throw new NotImplementedException();
    }
}
