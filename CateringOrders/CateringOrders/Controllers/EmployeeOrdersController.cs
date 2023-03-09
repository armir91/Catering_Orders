using CateringOrders.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CateringOrders.Controllers;

public class EmployeeOrdersController : Controller
{
	private readonly IEmployeeOrdersService _employeeOrdersService;

	public EmployeeOrdersController(IEmployeeOrdersService employeeOrdersService)
	{
		_employeeOrdersService = employeeOrdersService ?? throw new ArgumentNullException(nameof(employeeOrdersService));
	}

	public async Task<IActionResult> Index()
	{
		var resultTotal = await _employeeOrdersService.GetAll();

		return View(resultTotal);

	}
}
