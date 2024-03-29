﻿using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Data.Entities;
using CateringOrders.Data.Repositories.Implementations;

namespace CateringOrders.BLL.Services.Implementations;

public class FoodItemsService : IFoodItemsService
{

    private readonly IFoodItemsRepository _foodItemsRepository;
    public FoodItemsService(IFoodItemsRepository foodItemsRepository)

    {
        _foodItemsRepository = foodItemsRepository ?? throw new ArgumentNullException(nameof(foodItemsRepository));
    }

    public async Task<List<FoodItems>> GetAll(string searchString)
    {
        var result = await _foodItemsRepository.GetAllAsync(searchString);
        return result;
    }

    public async Task<FoodItems> Create(FoodItems foodItems)
    {
        var result = await _foodItemsRepository.Create(foodItems);
        return result;
    }

    public async Task<FoodItems> DeleteAsync(int id)
    {
        return await _foodItemsRepository.DeleteAsync(id);
    }

    public async Task<FoodItems> Update(int id)
    {
        return await _foodItemsRepository.GetAsync(id);
    }
    public async Task<FoodItems> Update(FoodItems foodItems)
    {
        return await _foodItemsRepository.Update(foodItems);
    }

    public async Task<FoodItems> GetAsync(int id)
    {
        return await _foodItemsRepository.GetAsync(id);
    }
}