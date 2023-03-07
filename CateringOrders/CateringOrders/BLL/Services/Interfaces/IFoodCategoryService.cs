using CateringOrders.Data.Entities;

namespace CateringOrders.BLL.Services.Interfaces;

public interface IFoodCategoryService
{
    Task<List<FoodCategory>> GetAll();
}
