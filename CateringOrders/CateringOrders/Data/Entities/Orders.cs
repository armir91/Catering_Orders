using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CateringOrders.Data.Entities;

public class Orders
{
    public int Id { get; set; }
    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public ApplicationUser? ApplicationUser { get; set; }
    public int FoodId { get; set; }
    [ForeignKey(nameof(FoodId))]

    [DisplayName("Employee Food Order")]
    public FoodItems? FoodItems { get; set; }
    public decimal Price { get; set; }
	public bool IsDeleted { get; set;}
}
