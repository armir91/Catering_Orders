using CateringOrders.Data.Entities;

namespace CateringOrders.BLL.Services.Interfaces;

public interface IFoodItemsService
{
    Task<List<FoodItems>> GetAll(string searchString);
    Task<FoodItems> Create(FoodItems foodItems);
    Task<FoodItems> DeleteAsync(int id);
    Task<FoodItems> Update(int id);
    Task<FoodItems> Update(FoodItems foodItems);
    Task<FoodItems> GetAsync(int id);
}
