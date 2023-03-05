using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CateringOrders.Data;
using CateringOrders.Data.Entities;

namespace CateringOrders.Areas.Identity.Pages.FoodItem
{
    public class DeleteModel : PageModel
    {
        private readonly CateringOrders.Data.ApplicationDbContext _context;

        public DeleteModel(CateringOrders.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public FoodItems FoodItems { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.FoodItems == null)
            {
                return NotFound();
            }

            var fooditems = await _context.FoodItems.FirstOrDefaultAsync(m => m.Id == id);

            if (fooditems == null)
            {
                return NotFound();
            }
            else 
            {
                FoodItems = fooditems;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.FoodItems == null)
            {
                return NotFound();
            }
            var fooditems = await _context.FoodItems.FindAsync(id);

            if (fooditems != null)
            {
                FoodItems = fooditems;
                _context.FoodItems.Remove(FoodItems);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
