using CateringOrders.BLL.Services.Implementations;
using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CateringOrders.Controllers
{
    public class DailyMenuController  : Controller
    {

        private readonly IDailyMenuService _dailyMenuService;

        public DailyMenuController(IDailyMenuService dailyMenuService)
        {
            _dailyMenuService = dailyMenuService ?? throw new ArgumentNullException(nameof(dailyMenuService));
        }

        public async Task<IActionResult> Index()
        {
            var resultTotal = await _dailyMenuService.GetAll();

            return View(resultTotal);

        }
    }
}
