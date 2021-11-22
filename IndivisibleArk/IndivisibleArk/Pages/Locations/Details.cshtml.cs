using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndivisibleArk.Data;
using IndivisibleArk.Models;

namespace IndivisibleArk.Pages.Locations
{
    public class DetailsModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public DetailsModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public Location Location { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Location = await _context.Locations.FirstOrDefaultAsync(m => m.LocationId == id);

            if (Location == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
