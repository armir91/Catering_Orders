using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CateringOrders.Data;
using CateringOrders.Data.Entities;

namespace CateringOrders.Areas.Identity.Pages.DailyMenuOperations
{
    public class DetailsModel : PageModel
    {
        private readonly CateringOrders.Data.ApplicationDbContext _context;

        public DetailsModel(CateringOrders.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DailyMenu DailyMenu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DailyMenus == null)
            {
                return NotFound();
            }

            var dailymenu = await _context.DailyMenus.FirstOrDefaultAsync(m => m.Id == id);
            if (dailymenu == null)
            {
                return NotFound();
            }
            else 
            {
                DailyMenu = dailymenu;
            }
            return Page();
        }
    }
}
