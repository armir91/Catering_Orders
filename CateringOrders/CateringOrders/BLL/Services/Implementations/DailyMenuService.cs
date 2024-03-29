﻿using CateringOrders.BLL.Services.Interfaces;
using CateringOrders.Data.Entities;
using CateringOrders.Data.Repositories.Implementations;
using CateringOrders.Data.Repositories.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace CateringOrders.BLL.Services.Implementations;

public class DailyMenuService : IDailyMenuService
{
    private readonly IDailyMenuRepository _dailyMenuRepository;
    public DailyMenuService(IDailyMenuRepository dailyMenuRepository)
    {
        _dailyMenuRepository = dailyMenuRepository ?? throw new ArgumentNullException(nameof(dailyMenuRepository));
    }
    public async Task<List<DailyMenu>> GetAll()
    {
        var result = await _dailyMenuRepository.GetAllAsync();
        return result;
    }
    public async Task<DailyMenu> Create(DailyMenu dailyMenu)
    {
        var result = await _dailyMenuRepository.Create(dailyMenu);
        return result;

    }

    public async Task<DailyMenu> DeleteAsync(int id)
    {
        return await _dailyMenuRepository.DeleteAsync(id);
    }
}
