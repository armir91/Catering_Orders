using CateringOrders.Data.Entities;
using CateringOrders.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CateringOrders.Data.Repositories.Implementations;

public class DailyMenuRepository : IDailyMenuRepository
{
    private readonly ApplicationDbContext _context;

    public DailyMenuRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<DailyMenu>> GetAllAsync()
    {
        var result = await _context.DailyMenus
            .Include(d => d.FoodItems)
            .ToListAsync();
        return result;
    }

    public async Task<DailyMenu> Create(DailyMenu dailyMenu)
    {
        await _context.DailyMenus.AddAsync(dailyMenu);
        await _context.SaveChangesAsync();
        return (dailyMenu);
    }

    public Task<DailyMenu> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<DailyMenu> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DailyMenu> UpdateAsync(DailyMenu dailyMenu)
    {
        throw new NotImplementedException();
    }

}
