using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Data.Repositories.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace CateringOrders.Controllers;

public class FoodCategoryController : Controller
{
    private readonly IFoodCategoryService _foodCategoryService;

    public FoodCategoryController(IFoodCategoryService foodCategoryService)
    {
        _foodCategoryService = foodCategoryService ?? throw new ArgumentNullException(nameof(foodCategoryService));
    }

    public async Task<IActionResult> Index()
    {
        var resultTotal = await _foodCategoryService.GetAll();

        return View(resultTotal);

    }
}
