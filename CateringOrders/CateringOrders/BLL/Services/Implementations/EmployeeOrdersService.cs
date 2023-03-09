using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Data.Entities;
using CateringOrders.Data.Repositories.Implementations;
using CateringOrders.Data.Repositories.Interfaces;

namespace CateringOrders.BLL.Services.Implementations;

public class EmployeeOrdersService : IEmployeeOrdersService
{
	private readonly IEmployeeOrdersRepository _employeeOrdersRepository;

    public EmployeeOrdersService(IEmployeeOrdersRepository employeeOrdersRepository)
    {
		_employeeOrdersRepository = employeeOrdersRepository ?? throw new ArgumentNullException(nameof(employeeOrdersRepository));

	}
    public async Task<List<Orders>> GetAll()
	{
		var result = await _employeeOrdersRepository.GetAllAsync();
		return result;
	}
}
