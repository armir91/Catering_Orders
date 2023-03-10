using CateringOrders.Data.Entities;

namespace CateringOrders.Data.Repositories.Interfaces;

public interface IDailyMenuRepository
{
    Task<List<DailyMenu>> GetAllAsync();
    Task<DailyMenu> AddAsync(DailyMenu dailyMenu);
    Task<DailyMenu> UpdateAsync(DailyMenu dailyMenu);
    Task<DailyMenu> DeleteAsync(int id);
    Task<DailyMenu> GetAsync(int id);
    Task<bool> ExistAsync(string name);
}
