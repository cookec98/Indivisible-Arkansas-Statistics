using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndivisibleArk.Data;
using IndivisibleArk.Models;

namespace IndivisibleArk.Pages.Interests
{
    public class DeleteModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public DeleteModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Interest Interest { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interest = await _context.Interests.FirstOrDefaultAsync(m => m.InterestId == id);

            if (Interest == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interest = await _context.Interests.FindAsync(id);

            if (Interest != null)
            {
                _context.Interests.Remove(Interest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
