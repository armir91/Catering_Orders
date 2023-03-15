using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

    public async Task<IActionResult> Index(string searchString)
    {
        var resultTotal = await _foodItemsService.GetAll(searchString);
        return View(resultTotal);
    }
    public async Task<ActionResult> Create(string searchString)
    {
        var foodCategories = await _foodCategoryService.GetAll();
        ViewBag.FoodCategories = foodCategories;
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(FoodItems foodItems)
    {
        var result = await _foodItemsService.Create(foodItems);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<ActionResult> Delete(int id)
    {
        var softDelete = await _foodItemsService.DeleteAsync(id);
        return View(softDelete);
    }

    [HttpPost]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        await _foodItemsService.DeleteAsync(id);
        return RedirectToAction("Index");
    }

    public async Task<ActionResult> Edit(int Id, string searchString)
    {

        var foodItem = await _foodItemsService.GetAsync(Id);
        if (foodItem == null)
        {
            return NotFound();
        }

        var foodItems = await _foodCategoryService.GetAll();
        ViewBag.CategoryId = new SelectList(foodItems, "Id", "Name", foodItem.CategoryId);

        return View(foodItem);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit(FoodItems foodItems)
    {
        await _foodItemsService.Update(foodItems);
        return RedirectToAction("Index");
    }

}
