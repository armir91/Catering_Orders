using CateringOrders.Data.Entities;

namespace CateringOrders.Data.Repositories.Implementations
{
    public interface IFoodCategoryRepository
    {
        Task<List<FoodCategory>> GetAll();

    }
}