using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CateringOrders.Data;
using CateringOrders.Data.Entities;

namespace CateringOrders.Areas.Identity.Pages.EmployeeOrders;

public class EditModel : PageModel
{
    private readonly CateringOrders.Data.ApplicationDbContext _context;

    public EditModel(CateringOrders.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Orders Orders { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null || _context.Orders == null)
        {
            return NotFound();
        }

        var orders =  await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);
        if (orders == null)
        {
            return NotFound();
        }
        Orders = orders;
       ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
       ViewData["FoodId"] = new SelectList(_context.FoodItems, "Id", "Id");
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Orders).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!OrdersExists(Orders.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool OrdersExists(int id)
    {
      return _context.Orders.Any(e => e.Id == id);
    }
}
