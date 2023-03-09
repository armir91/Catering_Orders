using CateringOrders.Data.Entities;

namespace CateringOrders.Data.Repositories.Interfaces;

public interface IEmployeeOrdersRepository
{
	Task<List<Orders>> GetAllAsync();
	Task<Orders> AddAsync(Orders orders);
	Task<Orders> UpdateAsync(Orders orders);
	Task<Orders> DeleteAsync(int id);
	Task<Orders> GetAsync(int id);
	Task<bool> ExistAsync(string name);
}