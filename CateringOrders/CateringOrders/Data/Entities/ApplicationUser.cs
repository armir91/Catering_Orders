using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace CateringOrders.Data.Entities;

public class ApplicationUser : IdentityUser<int>
{
    [DisplayName("Employee Name")]
    public string? FirstName { get; set; }

    [DisplayName("Employee Surname")]
    public string? LastName { get; set; }
    public DateTime? BirthDate { get; set; }

    [DisplayName("ID Number")]
    public string? DocumentIdNumber { get; set; }
    public DateTime? RegisteredDate { get; set; }
    public DateTime? LastLogin { get; set; }
    public bool? IsDeleted { get; set; }
}
