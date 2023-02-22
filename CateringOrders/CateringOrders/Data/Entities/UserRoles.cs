using System.ComponentModel.DataAnnotations.Schema;

namespace CateringOrders.Data.Entities;

public class UserRoles
{
    public int Id { get; set; }

    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public ApplicationUser? ApplicationUser { get; set; }

    public int RoleId { get; set; }
    [ForeignKey(nameof(RoleId))]
    public ApplicationRole? ApplicationRole { get; set; }
}
