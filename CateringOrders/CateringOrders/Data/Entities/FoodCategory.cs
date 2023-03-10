using MessagePack;
using System.ComponentModel;

namespace CateringOrders.Data.Entities;

public class FoodCategory
{
	public int Id { get; set; }

    [DisplayName("Food Category")]
    public string? Name { get; set; }
}
