using CateringOrders.Data.Entities;

namespace CateringOrders.BLL.Services.Interfaces;

public interface IDailyMenuService
{
    Task<List<DailyMenu>> GetAll();
}
