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

public class DeleteModel : PageModel
{
    private readonly CateringOrders.Data.ApplicationDbContext _context;

    public DeleteModel(CateringOrders.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
  public Orders Orders { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null || _context.Orders == null)
        {
            return NotFound();
        }

        var orders = await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);

        if (orders == null)
        {
            return NotFound();
        }
        else 
        {
            Orders = orders;
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null || _context.Orders == null)
        {
            return NotFound();
        }
        var orders = await _context.Orders.FindAsync(id);

        if (orders != null)
        {
            Orders = orders;
            _context.Orders.Remove(Orders);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
