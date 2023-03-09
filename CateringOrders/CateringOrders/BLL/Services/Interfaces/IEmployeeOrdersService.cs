using CateringOrders.Data.Entities;

namespace CateringOrders.BLL.Services.Interfaces;

public interface IEmployeeOrdersService
{
	Task<List<Orders>> GetAll();
}
