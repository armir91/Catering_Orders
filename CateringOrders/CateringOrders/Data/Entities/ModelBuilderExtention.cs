using Microsoft.EntityFrameworkCore;

namespace CateringOrders.Data.Entities;

public static class ModelBuilderExtention
{
    public static void Seed(this ModelBuilder builder)
    {

        var salad = new FoodCategory
        {
            Id = 1,
            Name = "Salads"
        };

        _ = builder.Entity<FoodCategory>().HasData(salad);

        var mainPlate = new FoodCategory
        {
            Id = 2,
            Name = "Main Plate"
        };

        _ = builder.Entity<FoodCategory>().HasData(mainPlate);

        var desserts = new FoodCategory
        {
            Id = 3,
            Name = "Dessert"
        };

        _ = builder.Entity<FoodCategory>().HasData(desserts);

        var fruits = new FoodCategory
        {
            Id = 4,
            Name = "Fruits"
        };

        _ = builder.Entity<FoodCategory>().HasData(fruits);
    }
}
