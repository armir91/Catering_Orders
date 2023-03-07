using CateringOrders.Data.Entities;

namespace CateringOrders.Data.Repositories.Implementations;

public interface IFoodCategoryRepository
{
    Task<List<FoodCategory>> GetAllAsync();
    Task<FoodCategory> AddAsync(FoodCategory foodCategory);
    Task<FoodCategory> UpdateAsync(FoodCategory foodCategory);
    Task<FoodCategory> DeleteAsync(int id);
    Task<FoodCategory> GetAsync(int id);
    Task<bool> ExistAsync(string name);

}