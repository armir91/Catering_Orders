using System.ComponentModel.DataAnnotations.Schema;

namespace CateringOrders.Data.Entities;

public class DailyMenu
{
	public int Id { get; set; }
	public DateTime Date { get; set; }
	public bool IsDeleted { get; set; }

    public int FoodId { get; set; }
    [ForeignKey(nameof(FoodId))]
    public FoodItems? FoodItems { get; set; }
}
