using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Data.Entities;
using CateringOrders.Data.Repositories.Implementations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CateringOrders.BLL.Services.Implementations;

public class FoodCategoryService : IFoodCategoryService
{
    private readonly IFoodCategoryRepository _foodCategoryRepository;

    public FoodCategoryService(IFoodCategoryRepository foodCategoryRepository)
    {
        _foodCategoryRepository = foodCategoryRepository ?? throw new ArgumentNullException(nameof(foodCategoryRepository));
    }
    public async Task<List<FoodCategory>> GetAll()
    {
        var result = await _foodCategoryRepository.GetAllAsync();
        return result;
    }
}
