using CateringOrders.Data.Entities;
using CateringOrders.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CateringOrders.Data.Repositories.Implementations;

public class EmployeeOrdersRepository : IEmployeeOrdersRepository
{
	private readonly ApplicationDbContext _context;

	public EmployeeOrdersRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<List<Orders>> GetAllAsync()
	{
          var result = await _context.Orders
            .Include(o => o.ApplicationUser)
            .Include(o => o.FoodItems).ToListAsync();

        return result;
	}

	public Task<Orders> AddAsync(Orders orders)
	{
		throw new NotImplementedException();
	}

	public Task<Orders> DeleteAsync(int id)
	{
		throw new NotImplementedException();
	}

	public Task<bool> ExistAsync(string name)
	{
		throw new NotImplementedException();
	}

	public Task<Orders> GetAsync(int id)
	{
		throw new NotImplementedException();
	}

	public Task<Orders> UpdateAsync(Orders orders)
	{
		throw new NotImplementedException();
	}
}
