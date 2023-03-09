using CateringOrders.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CateringOrders.Controllers
{
    public class FoodItemsController :Controller
    {
        private readonly IFoodItemsService _foodItemsService;

        public FoodItemsController(IFoodItemsService foodItemsService)
        {
            _foodItemsService = foodItemsService ?? throw new ArgumentNullException(nameof(foodItemsService));
        }

        public async Task<IActionResult> Index()
        {
            var resultTotal = await _foodItemsService.GetAll();

            return View(resultTotal);

        }
    }
}
