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

namespace CateringOrders.Areas.Identity.Pages.DailyMenuOperations
{
    public class EditModel : PageModel
    {
        private readonly CateringOrders.Data.ApplicationDbContext _context;

        public EditModel(CateringOrders.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DailyMenu DailyMenu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DailyMenus == null)
            {
                return NotFound();
            }

            var dailymenu =  await _context.DailyMenus.FirstOrDefaultAsync(m => m.Id == id);
            if (dailymenu == null)
            {
                return NotFound();
            }
            DailyMenu = dailymenu;
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

            _context.Attach(DailyMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DailyMenuExists(DailyMenu.Id))
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

        private bool DailyMenuExists(int id)
        {
          return _context.DailyMenus.Any(e => e.Id == id);
        }
    }
}
