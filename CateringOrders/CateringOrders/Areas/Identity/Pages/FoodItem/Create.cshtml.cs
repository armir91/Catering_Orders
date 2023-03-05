using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CateringOrders.Data;
using CateringOrders.Data.Entities;

namespace CateringOrders.Areas.Identity.Pages.FoodItem
{
    public class CreateModel : PageModel
    {
        private readonly CateringOrders.Data.ApplicationDbContext _context;

        public CreateModel(CateringOrders.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_context.FoodCategory, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public FoodItems FoodItems { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FoodItems.Add(FoodItems);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
