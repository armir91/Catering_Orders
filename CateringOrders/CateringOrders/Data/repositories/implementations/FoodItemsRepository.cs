﻿using CateringOrders.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CateringOrders.Data.Repositories.Implementations;

public class FoodItemsRepository : IFoodItemsRepository
{
    private readonly ApplicationDbContext _context;
    public FoodItemsRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<FoodItems>> GetAllAsync()
    {
        var result = await _context.FoodItems.ToListAsync();
        return result;
    }
    public Task<FoodItems> AddAsync(FoodItems foodItems)
    {
        throw new NotImplementedException();
    }
    public Task<FoodItems> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task<bool> ExistAsync(string name)
    {
        throw new NotImplementedException();
    }
    public Task<FoodItems> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task<FoodItems> UpdateAsync(FoodItems foodItems)
    {
        throw new NotImplementedException();
    }
}
