using CateringOrders.Data.Entities;

namespace CateringOrders.BLL.Services.Interfaces;

public interface IDailyMenuService
{
    Task<List<DailyMenu>> GetAll();
    Task<DailyMenu> Create(DailyMenu dailyMenu);
    Task<DailyMenu> DeleteAsync(int id);
}
