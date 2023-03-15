using CateringOrders.BLL.Services.Implementations;
using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Controllers;
using CateringOrders.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CateringOrders.Controllers
{
    public class DailyMenuController : Controller
    {

        private readonly IDailyMenuService _dailyMenuService;
        private readonly IFoodItemsService _foodItemsService;

        public DailyMenuController(IDailyMenuService dailyMenuService, IFoodItemsService foodItemsService)
        {
            _dailyMenuService = dailyMenuService ?? throw new ArgumentNullException(nameof(dailyMenuService));
            _foodItemsService = foodItemsService;
        }

        public async Task<IActionResult> Index()
        {
            var resultTotal = await _dailyMenuService.GetAll();

            return View(resultTotal);

        }

        //Breakpoint, new Implementations added for DailyMenuController
        public async Task<ActionResult> Create(string searchString)
        {
            var foodList = await _foodItemsService.GetAll(searchString);
            ViewBag.FoodList = new SelectList(foodList, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(DailyMenu dailyMenu)
        {
            var result = await _dailyMenuService.Create(dailyMenu);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            var softDelete = await _dailyMenuService.DeleteAsync(id);
            return View(softDelete);
        }

        [HttpPost]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _dailyMenuService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }

}
