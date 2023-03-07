using CateringOrders.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CateringOrders.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DailyMenu> DailyMenus { get; set; } = null;
    public virtual DbSet<FoodItems> FoodItems { get; set; } = null;
    public virtual DbSet<FoodCategory> FoodCategory { get; set; } = null;
    public virtual DbSet<Orders> Orders { get; set; } = null;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>().ToTable("Users");
        builder.Entity<ApplicationRole>().ToTable("Roles");


        builder.Seed();
    }
}