using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Data.Entities;
using CateringOrders.Data.Repositories.Implementations;

namespace CateringOrders.BLL.Services.Implementations;

public class FoodItemsService : IFoodItemsService
{

    private readonly IFoodItemsRepository _foodItemsRepository;
    public FoodItemsService(IFoodItemsRepository foodItemsRepository)

    {
        _foodItemsRepository = foodItemsRepository ?? throw new ArgumentNullException(nameof(foodItemsRepository));
    }

    public async Task<List<FoodItems>> GetAll()
    {
        var result = await _foodItemsRepository.GetAllAsync();
        return result;
    }

    public Task<FoodItems> Create(FoodItems foodItems)
    {
        var result = _foodItemsRepository.Create(foodItems);
        return result;
    }
}