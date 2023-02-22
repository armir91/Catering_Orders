using Microsoft.AspNetCore.Identity;

namespace CateringOrders.Data.Entities;

public class ApplicationUser : IdentityUser<int>
{
    public ApplicationUser()
    {
        UserRoles = new HashSet<UserRoles>();
    }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? DocumentIdNumber { get; set; }
    public DateTime? RegisteredDate { get; set; }
    public DateTime? LastLogin { get; set; }
    public bool? IsDeleted { get; set; }
    public virtual ICollection<UserRoles>? UserRoles { get; set; }
}
