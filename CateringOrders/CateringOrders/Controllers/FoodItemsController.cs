using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace CateringOrders.Controllers;

public class FoodItemsController : Controller
{
    private readonly IFoodItemsService _foodItemsService;
    private readonly IFoodCategoryService _foodCategoryService;

    public FoodItemsController(IFoodItemsService foodItemsService, IFoodCategoryService foodCategoryService)
    {
        _foodItemsService = foodItemsService ?? throw new ArgumentNullException(nameof(foodItemsService));
        _foodCategoryService = foodCategoryService ?? throw new ArgumentNullException(nameof(_foodCategoryService));
    }

    public async Task<IActionResult> Index()
    {
        var resultTotal = await _foodItemsService.GetAll();
        return View(resultTotal);
    }

    public async Task<IActionResult> Create()
    {
        var foodCategories = await _foodCategoryService.GetAll();
        ViewBag.FoodCategories = foodCategories;
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(FoodItems foodItems)
    {
        var result = await _foodItemsService.Create(foodItems);

        return View(result);
    }
}
