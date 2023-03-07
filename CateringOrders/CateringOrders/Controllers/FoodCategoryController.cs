using CateringOrders.Data.Repositories.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace CateringOrders.Controllers;

public class FoodCategoryController : Controller
{
    private readonly IFoodCategoryRepository _foodCategoryRepository;

    public FoodCategoryController(IFoodCategoryRepository foodCategoryRepository)
    {
        _foodCategoryRepository = foodCategoryRepository ?? throw new ArgumentNullException(nameof(foodCategoryRepository));
    }

    public async Task<IActionResult> Index()
    {
        var resultTotal = await _foodCategoryRepository.GetAll();

        return View(resultTotal);

    }
}
