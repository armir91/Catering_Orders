﻿using CateringOrders.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CateringOrders.Data.Repositories.Implementations;

public class FoodItemsRepository : IFoodItemsRepository
{
    private readonly ApplicationDbContext _context;
    public FoodItemsRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<FoodItems>> GetAllAsync(string searchString)
    {
        var result = await _context.FoodItems
            .Include(f => f.FoodCategory).Where(FoodItems => FoodItems.IsDeleted == false)
            .ToListAsync();

        if (!string.IsNullOrEmpty(searchString))
        {
            result = await _context.FoodItems
            .Include(f => f.FoodCategory)
            .Where(FoodItems => FoodItems.IsDeleted == false && (FoodItems.Name)
            .Contains(searchString)).ToListAsync();
        }

        return result;
    }
    public async Task<FoodItems> Create(FoodItems foodItems)
    {
        await _context.FoodItems.AddAsync(foodItems);
        await _context.SaveChangesAsync();
        return (foodItems);
    }
    public async Task<FoodItems> DeleteAsync(int id)
    {
        var softDeleteItem = await _context.FoodItems.FindAsync(id);
        softDeleteItem.IsDeleted = true;
        _context.FoodItems.Update(softDeleteItem);
        await _context.SaveChangesAsync();

        return softDeleteItem;
    }
    public Task<bool> ExistAsync(string name)
    {
        throw new NotImplementedException();
    }
    public async Task<FoodItems> GetAsync(int id)
    {
        var foodItem = await _context.FoodItems.FindAsync(id);
        return foodItem;
    }
    public async Task<FoodItems> Update(int id)
    {
        return await _context.FoodItems.FindAsync(id);
    }
    public async Task<FoodItems> Update(FoodItems booking)
    {
        _context.FoodItems.Update(booking);
        await _context.SaveChangesAsync();
        return booking;
    }
}
