using Microsoft.AspNetCore.Identity;

namespace CateringOrders.Data.Entities;

public class ApplicationUser : IdentityUser<int>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public string DocumentIdNumber { get; set; } = null!;
    public DateTime RegisteredDate { get; set; }
    public DateTime LastLogin { get; set; }
    public bool IsDeleted { get; set; }
}
