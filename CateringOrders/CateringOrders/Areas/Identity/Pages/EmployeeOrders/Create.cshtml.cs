using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CateringOrders.Data;
using CateringOrders.Data.Entities;

namespace CateringOrders.Areas.Identity.Pages.EmployeeOrders;

public class CreateModel : PageModel
{
    private readonly CateringOrders.Data.ApplicationDbContext _context;

    public CreateModel(CateringOrders.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
    ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
    ViewData["FoodId"] = new SelectList(_context.FoodItems, "Id", "Id");
        return Page();
    }

    [BindProperty]
    public Orders Orders { get; set; }
    

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
      if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Orders.Add(Orders);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
