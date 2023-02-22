using System.ComponentModel.DataAnnotations.Schema;

namespace CateringOrders.Data.Entities;

public class FoodItems
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Description { get; set; }
	public decimal Price { get; set; }
	public bool IsDeleted { get; set; }

	public int CategoryId { get; set; }
	[ForeignKey(nameof(CategoryId))]
	public FoodCategory? FoodCategory { get; set; }
}
