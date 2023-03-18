﻿using CateringOrders.Data.Entities;

namespace CateringOrders.Data.Repositories.Implementations
{
    public interface IFoodItemsRepository
    {
        Task<List<FoodItems>> GetAllAsync();
        Task<FoodItems> Create(FoodItems foodItems);
        Task<FoodItems> DeleteAsync(int id);
        Task<FoodItems> GetAsync(int id);
        Task<bool> ExistAsync(string name);

        Task<FoodItems> Edit(int id);
        Task<FoodItems> Edit(FoodItems foodItems);
    }
}