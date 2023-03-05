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

namespace CateringOrders.Areas.Identity.Pages.FoodItem
{
    public class EditModel : PageModel
    {
        private readonly CateringOrders.Data.ApplicationDbContext _context;

        public EditModel(CateringOrders.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FoodItems FoodItems { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.FoodItems == null)
            {
                return NotFound();
            }

            var fooditems =  await _context.FoodItems.FirstOrDefaultAsync(m => m.Id == id);
            if (fooditems == null)
            {
                return NotFound();
            }
            FoodItems = fooditems;
           ViewData["CategoryId"] = new SelectList(_context.FoodCategory, "Id", "Id");
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

            _context.Attach(FoodItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodItemsExists(FoodItems.Id))
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

        private bool FoodItemsExists(int id)
        {
          return _context.FoodItems.Any(e => e.Id == id);
        }
    }
}
