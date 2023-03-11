using CateringOrders.Data.Entities;

namespace CateringOrders.BLL.Services.Interfaces;

public interface IFoodItemsService
{
    Task<List<FoodItems>> GetAll();
    Task<FoodItems> Create(FoodItems foodItems);
}
