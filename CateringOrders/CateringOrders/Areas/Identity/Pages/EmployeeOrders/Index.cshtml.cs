using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CateringOrders.Data;
using CateringOrders.Data.Entities;

namespace CateringOrders.Areas.Identity.Pages.EmployeeOrders;

public class IndexModel : PageModel
{
    private readonly CateringOrders.Data.ApplicationDbContext _context;

    public IndexModel(CateringOrders.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Orders> Orders { get;set; } = default!;

    public async Task OnGetAsync()
    {
        if (_context.Orders != null)
        {
            Orders = await _context.Orders
            .Include(o => o.ApplicationUser)
            .Include(o => o.FoodItems).ToListAsync();
        }
    }
}
