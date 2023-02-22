using Microsoft.AspNetCore.Identity;

namespace CateringOrders.Data.Entities;

public class ApplicationRole : IdentityRole<int>
{
	public string? Code { get; set; }
}
